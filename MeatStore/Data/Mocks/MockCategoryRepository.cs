using System;
using System.Collections.Generic;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;

namespace MeatStore.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Cow Meat", Description = "All Cow meats" },
                    new Category { CategoryName = "Pork Meat", Description = "All Pork meats" }
                };
            }
        }
    }
}
