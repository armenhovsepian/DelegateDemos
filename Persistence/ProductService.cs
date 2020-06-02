using Persistence.Model;
using System.Linq;

namespace Persistence.Data
{
    public class ProductService
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public IQueryable<Product> Products => _dbContext.Products;

        public Product GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Products.Find(id);
                return product;
            }
        }
    }
}
