using System;
using System.Collections.Generic;
using MeatStore.Data.Models;

namespace MeatStore.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
