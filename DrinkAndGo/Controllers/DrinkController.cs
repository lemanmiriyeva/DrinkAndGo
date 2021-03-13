using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Abstract;
using DrinkAndGo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController:Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var model=new DrinkListViewModel()
            {
                Drinks = _drinkRepository.Drinks
            };
            return View(model);
            
        }
    }
}
