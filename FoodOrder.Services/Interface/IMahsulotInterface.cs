using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodOrder.Services.Interface
{
    public interface IMahsulotInterface
    {
        Task<List<Mahsulot>> GetMahsulotlar();
        Task<Mahsulot> GetByIdMahsulotlar(Guid id);
        Task<Mahsulot> AddMahsulotlar(Mahsulot newMahsulot);
        Task<Mahsulot> UpdateMahsulotlar(Mahsulot mahsulot);
        Task DeleteMahsulotlar(Guid id);

    }
}
