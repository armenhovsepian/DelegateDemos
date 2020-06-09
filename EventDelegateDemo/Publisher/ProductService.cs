using Persistence.Data;
using Persistence.Model;
using System;

namespace EventDelegateDemo.Publisher
{
    public class ProductService
    {
        public delegate void ProductUpdatedEventHandler(Product sender, ProductEventArgs e);
        public event ProductUpdatedEventHandler ProductUpdatedEvent;

        public void BackInStock(Product product)
        {
            var repository = new ProductRepository();
            repository.Update(product);
            OnProductUpdated(product, new ProductEventArgs { 
                ModifiedAt = DateTimeOffset.UtcNow
            });
        }

        protected virtual void OnProductUpdated(Product product, ProductEventArgs e)
        {
            ProductUpdatedEvent?.Invoke(product, e);
        }
    }
}
