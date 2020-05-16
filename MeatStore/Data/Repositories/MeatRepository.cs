using System;
using System.Collections.Generic;
using System.Linq;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MeatStore.Data.Repositories
{
    public class MeatRepository : IMeatRepository
    {
        private readonly AppDbContext _appDbContext;

        public MeatRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Meat> Meats => _appDbContext.Meats.Include(c => c.Category);

        public IEnumerable<Meat> PreferredMeats => _appDbContext.Meats
            .Where(m => m.IsPreferredMeat == true)
            .Include(c => c.Category);

        public Meat GetMeatById(int meatId) => _appDbContext.Meats.FirstOrDefault(m => m.MeatId == meatId);
    }
}
