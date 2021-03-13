using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.DataAccess.Entity
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Drink Drink { get; set; }
        public int Amount { get; set; }
        public string CartId { get; set; }
    }
}
