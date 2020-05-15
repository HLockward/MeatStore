using System;
using System.Collections.Generic;
using MeatStore.Data.Models;

namespace MeatStore.ViewModels
{
    public class MeatsListViewModel
    {
        public IEnumerable<Meat> Meats { get; set; }
        public string CurrentCategory { get; set; }
    }
}
