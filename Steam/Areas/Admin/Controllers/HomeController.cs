using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly EFDBContext _context;
        public HomeController(DataManager dataManager,EFDBContext context)
        {
            this.dataManager = dataManager;
            _context = context;
        }
        public IActionResult Index()
        {
            
            List<Games> games = _context.Games.ToList();
            return View(games);
        }
    }
}
