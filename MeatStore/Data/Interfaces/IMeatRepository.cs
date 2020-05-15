using System;
using System.Collections.Generic;
using MeatStore.Data.Models;

namespace MeatStore.Data.Interfaces
{
    public interface IMeatRepository
    {
        IEnumerable<Meat> Meats { get; set; }
        IEnumerable<Meat> PreferredMeats { get; set; }
        Meat GetMeatById(int meatId);
    }
}
