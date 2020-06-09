using Persistence.Model;
using System.Collections.Generic;
using System.Linq;

namespace Persistence.Data
{
    public class ProductRepository
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public IQueryable<Product> Products => _dbContext.Products;

        public Product GetById(int id) => _dbContext.Products.Find(id);

        public List<Product> GetAll() => _dbContext.Products.ToList();

        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
            //_dbContext.SaveChanges();
        }
    }
}
