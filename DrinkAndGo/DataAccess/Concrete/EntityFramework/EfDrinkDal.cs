using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Abstract;
using DrinkAndGo.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DrinkAndGo.DataAccess.Concrete.EntityFramework
{
    public class EfDrinkDal:IDrinkRepository
    {
        private readonly AppContext _appContext;

        public EfDrinkDal(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Drink> Drinks => _appContext.Drinks.Include(c=>c.Category);
        

        public IEnumerable<Drink> PreferredDrinks => _appContext.Drinks.Where(d => d.IsPreferredDrink == true).Include(c=>c.Category);

        public Drink GetDrinkById(int drinkId) => _appContext.Drinks.FirstOrDefault(d => d.DrinkId == drinkId);
    }
}
