using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodOrder.Services.Interface
{
    public interface IKatagoriyaInterface
    {
        Task<List<Katagoriya>> GetKatagoriya();
        Task<Katagoriya> GetByIdKatagoriya(Guid id);
        Task<Katagoriya> AddKatagoriya(Katagoriya newKatagoriya);
        Task<Katagoriya> UpdateKatagoriya(Katagoriya katagoriya);
        Task DeleteKatagoriya(Guid id);
    }
}
