using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DrinkAndGo.DataAccess.Entity
{
    public class Cart
    {
        private readonly AppContext _appDbContext;
        private Cart(AppContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public string CartId { get; set; }
        public List<CartItem> CartItems { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new Cart(context) { CartId = cartId };
        }

        public void AddToCart(Drink drink, int amount)
        {
            var shoppingCartItem =
                    _appDbContext.CartItems.SingleOrDefault(
                        s => s.Drink.DrinkId == drink.DrinkId && s.CartId == CartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new CartItem
                {
                    CartId = CartId,
                    Drink = drink,
                    Amount = 1
                };

                _appDbContext.CartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Drink drink)
        {
            var shoppingCartItem =
                    _appDbContext.CartItems.SingleOrDefault(
                        s => s.Drink.DrinkId == drink.DrinkId && s.CartId == CartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.CartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<CartItem> GetShoppingCartItems()
        {
            return CartItems ??= _appDbContext.CartItems.Where(c => c.CartId == CartId)
                .Include(s => s.Drink)
                .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .CartItems
                .Where(cart => cart.CartId == CartId);

            _appDbContext.CartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.CartItems.Where(c => c.CartId == CartId)
                .Select(c => c.Drink.Price * c.Amount).Sum();
            return total;
        }
    }
}
    
