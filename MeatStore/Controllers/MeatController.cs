using System;
using System.Collections.Generic;
using System.Linq;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;
using MeatStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MeatStore.Controllers
{
    public class MeatController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMeatRepository _meatRepository;

        public MeatController(ICategoryRepository categoryRepository, IMeatRepository meatRepository)
        {
            _categoryRepository = categoryRepository;
            _meatRepository = meatRepository;
        }
        [Route("Meat/List")]
        public ViewResult List()
        {
            MeatsListViewModel vm = new MeatsListViewModel();
            vm.Meats = _meatRepository.Meats;
            vm.CurrentCategory = "All meats";

            return View(vm);
        }
        [Route("Meat/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Meat> meats;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                meats = _meatRepository.Meats.OrderBy(p => p.MeatId);
                currentCategory = "All meats";
            }
            else
            {
                if (string.Equals("Beef", _category, StringComparison.OrdinalIgnoreCase))
                    meats = _meatRepository.Meats.Where(p => p.Category.CategoryName.Equals("Beef")).OrderBy(p => p.Name);
                else
                    meats = _meatRepository.Meats.Where(p => p.Category.CategoryName.Equals("Pork")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new MeatsListViewModel
            {
                Meats = meats,
                CurrentCategory = currentCategory
            });
        }
    }
}
