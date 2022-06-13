using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Steam;
using Steam.Service;

namespace Steam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GamesController : Controller
    {
        private readonly DataManager dataManager;
        public GamesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(int id)
        {
            var entity = dataManager.Game.GetGameById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Games model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Game.SaveGame(model);
                return RedirectToAction("Index","Home","admin");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Game.DeleteGame(id);
            return RedirectToAction("Index", "Home", "admin");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Games model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Game.SaveGame(model);
                return RedirectToAction("Index", "Home", "admin");
            }
            return View(model);
        }
    }
}
