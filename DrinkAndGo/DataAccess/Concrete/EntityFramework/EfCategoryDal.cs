using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Abstract;
using DrinkAndGo.DataAccess.Entity;

namespace DrinkAndGo.DataAccess.Concrete.EntityFramework
{
    
    public class EfCategoryDal:ICategoryRepository
    {
        private readonly AppContext _appContext;

        public EfCategoryDal(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Category> Categories => _appContext.Categories;
    }
}
