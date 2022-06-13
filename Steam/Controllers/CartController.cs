using Microsoft.AspNetCore.Mvc;
using Steam.Models;
using Steam.Repos.Abstract;
using Steam.Repos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Controllers
{
    public class CartController:Controller
    {
        private readonly IGameRepos gameRep;
        private readonly Cart cart;

        public CartController(IGameRepos gameRep,Cart cart)
        {
            this.gameRep = gameRep;
            this.cart = cart;
        }
        public ViewResult Index()
        {
            var items = cart.getItems();
            cart.Items = items;
            var obj = new CartViewModel
            {
                cart = this.cart
            };
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = gameRep.GetGame().FirstOrDefault(i => i.Id == id);
            if(item!=null)
            {
                cart.AddItem(item);
            }
            return RedirectToAction("Index");
        }
    }
}
