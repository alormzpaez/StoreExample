using Microsoft.EntityFrameworkCore;
using StoreApi.DBContext;
using StoreApi.Models;

namespace StoreApi.Services
{
    public class VariantService : IVariantService
    {
        private StoreContext _dbContext;

        public VariantService(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Variant? Show(int id)
        {
            return _dbContext.Variants.Include(q => q.Product).FirstOrDefault(q => q.VariantID == id);
        }
    }

    public interface IVariantService
    {
        Variant? Show(int id);
    }
}
