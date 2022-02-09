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
    public class MahsulotRepasitory : IMahsulotInterface
    {
        private readonly AppDbContext _dbContext;

        public MahsulotRepasitory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Mahsulot> AddMahsulotlar(Mahsulot newMahsulot)
        {
            _dbContext.Mahsulotlar.Add(newMahsulot);
            _dbContext.SaveChanges();
            return Task.FromResult(newMahsulot);
        }

        public Task DeleteMahsulotlar(Guid id)
        {
            Mahsulot mahsulot = _dbContext.Mahsulotlar.FirstOrDefault(p => p.Id == id);
            _dbContext.Mahsulotlar.Remove(mahsulot);
            _dbContext.SaveChanges();
            return Task.FromResult(0);
        }

        public Task<Mahsulot> GetByIdMahsulotlar(Guid id) => _dbContext.Mahsulotlar.FirstOrDefaultAsync(p => p.Id == id);

        public Task<List<Mahsulot>> GetMahsulotlar() => _dbContext.Mahsulotlar.ToListAsync();

        public Task<Mahsulot> UpdateMahsulotlar(Mahsulot mahsulot)
        {
            _dbContext.Mahsulotlar.Update(mahsulot);
            return Task.FromResult(mahsulot);
        }
    }
}
