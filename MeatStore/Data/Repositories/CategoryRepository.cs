using System;
using System.Collections.Generic;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;

namespace MeatStore.Data.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
