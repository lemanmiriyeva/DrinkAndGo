using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Entity;

namespace DrinkAndGo.Models
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }

    }
}
