using System;
using MeatStore.Data.Interfaces;
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

        public ViewResult List()
        {
            MeatsListViewModel vm = new MeatsListViewModel();
            vm.Meats = _meatRepository.Meats;
            vm.CurrentCategory = "MeatCategory";

            return View(vm);
        }
    }
}
