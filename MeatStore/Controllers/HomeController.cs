using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeatStore.Data.Interfaces;
using MeatStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeatStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMeatRepository _meatRepository;
        public HomeController(IMeatRepository meatRepository)
        {
            _meatRepository = meatRepository;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredMeat = _meatRepository.PreferredMeats
            };
            return View(homeViewModel);
        }
    }
}
