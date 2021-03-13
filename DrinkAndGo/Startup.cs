using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DrinkAndGo.DataAccess.Abstract;
using DrinkAndGo.DataAccess.Concrete.EntityFramework;
using DrinkAndGo.DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AppContext = DrinkAndGo.DataAccess.AppContext;

namespace DrinkAndGo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private readonly IConfigurationRoot _configurationRoot;

        public Startup(IWebHostEnvironment environment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(environment.ContentRootPath).
                AddJsonFile("appsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            services.AddTransient<IDrinkRepository, EfDrinkDal>();
            services.AddTransient<ICategoryRepository,EfCategoryDal>();
            services.AddSession();
            services.AddSingleton(Cart.GetCart);
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            DbInitializer.Seed(serviceProvider);
        }
    }
}
