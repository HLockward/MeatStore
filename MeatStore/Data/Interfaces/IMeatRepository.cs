using System;
using System.Collections.Generic;
using MeatStore.Data.Models;

namespace MeatStore.Data.Interfaces
{
    public interface IMeatRepository
    {
        IEnumerable<Meat> Meats { get; }
        IEnumerable<Meat> PreferredMeats { get; }
        Meat GetMeatById(int meatId);
        void RemoveMeatFromStock(int meatId, int amount);
    }
}
