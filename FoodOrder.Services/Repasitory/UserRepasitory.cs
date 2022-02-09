using FoodOrder.DataLayer;
using FoodOrder.Services.Interface;

namespace FoodOrder.Services.Repasitory
{
    public class UserRepasitory : IUserInterface
    {
        private readonly AppDbContext _dbContext;
        public UserRepasitory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
