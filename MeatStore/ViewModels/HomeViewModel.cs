using System;
using System.Collections.Generic;
using MeatStore.Data.Models;

namespace MeatStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Meat> PreferredMeat { get; set; }
    }
}
