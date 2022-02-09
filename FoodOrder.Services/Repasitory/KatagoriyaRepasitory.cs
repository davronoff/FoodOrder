using FoodOrder.DataLayer;
using FoodOrder.Models;
using FoodOrder.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Services.Repasitory
{
    public class KatagoriyaRepasitory : IKatagoriyaInterface
    {
        private readonly AppDbContext _dbContext;
        public KatagoriyaRepasitory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Katagoriya> AddKatagoriya(Katagoriya newKatagoriya)
        {
            _dbContext.Katagoriyalar.Add(newKatagoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(newKatagoriya);
        }

        public Task DeleteKatagoriya(Guid id)
        {
            Katagoriya katagoriya = _dbContext.Katagoriyalar.FirstOrDefault(p => p.Id == id);
            _dbContext.Katagoriyalar.Remove(katagoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(0);
        }

        public Task<Katagoriya> GetByIdKatagoriya(Guid id)
        {
            var res = _dbContext.Katagoriyalar
                .Include(p => p.Mahsulotlar)
                .FirstOrDefault(p => p.Id == id);
            return Task.FromResult(res);
        }

        public Task<List<Katagoriya>> GetKatagoriya() => _dbContext.Katagoriyalar.ToListAsync();

        public Task<Katagoriya> UpdateKatagoriya(Katagoriya katagoriya)
        {
            _dbContext.Katagoriyalar.Update(katagoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(katagoriya);

        }
    }
}
