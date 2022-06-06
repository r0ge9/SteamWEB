using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Models
{
    public class Cart
    {
        public string CartId { get; set; }
        public List<GamesCartItem> Items { get; set; }
        private readonly EFDBContext context;

        public Cart(EFDBContext context)
        {
            this.context = context;
        }
        public static Cart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<EFDBContext>();
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", cartId);
            return new Cart(context) { CartId = cartId };
        }
        public void AddItem(Games game)
        {
            this.context.GamesCartItem.Add(new GamesCartItem
            {
                GamesCartId=CartId,
                Game=game,
                Price=game.NewPrice
            });
            context.SaveChanges();
        }
        public List<GamesCartItem> getItems()
        {
            return context.GamesCartItem.Where(x => x.GamesCartId == CartId).Include(i => i.Game).ToList();
        }
    }


}
