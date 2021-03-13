using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Abstract;
using DrinkAndGo.DataAccess.Entity;

namespace DrinkAndGo.DataAccess.Concrete
{
    public class CategoryDal:ICategoryRepository
    {
        private readonly List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category(){CategoryId = 1,CategoryName = "Alcoholic",Description = "All alcoholic drinks"},
                new Category(){CategoryId = 2,CategoryName = "Non-alcoholic",Description = "All non-alcoholic drinks"}
            };
        }


        public IEnumerable<Category> Categories => _categories;
    }
}
