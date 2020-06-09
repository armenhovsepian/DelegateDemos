using EventDelegateDemo.Publisher;
using EventDelegateDemo.Subscribers;
using Persistence.Data;
using Persistence.Model;
using System.Linq;

namespace EventDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService();
            productService.ProductUpdatedEvent += EmailSerivce.OnProductUpdated;
            productService.ProductUpdatedEvent += SmsService.OnProductUpdated;

            var product = GetUnavalableProduct();
            ++product.UnitsInStock;
            productService.BackInStock(product);
        }


        static Product GetUnavalableProduct()
        {
            var repository = new ProductRepository();
            return repository.Products.FirstOrDefault(p => p.UnitsInStock == 0);
        }

    }


}
