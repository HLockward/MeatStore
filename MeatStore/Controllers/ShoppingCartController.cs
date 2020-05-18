using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;
using MeatStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeatStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMeatRepository _meatRepository;
        private ShoppingCart _shoppingCart;

        public ShoppingCartController(IMeatRepository meatRepository, ShoppingCart shoppingCart)
        {
            _meatRepository = meatRepository;
            _shoppingCart = shoppingCart;
        }

       public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

        return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int meatId)
        {
            var selectedMeat = _meatRepository.Meats.FirstOrDefault(p => p.MeatId == meatId);
            if (selectedMeat != null)
            {
                _shoppingCart.AddToCart(selectedMeat, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int meatId)
        {
            var selectedMeat = _meatRepository.Meats.FirstOrDefault(p => p.MeatId == meatId);
            if (selectedMeat != null)
            {
                _shoppingCart.RemoveFromCart(selectedMeat);
            }
            return RedirectToAction("Index");
        }
    }
}
