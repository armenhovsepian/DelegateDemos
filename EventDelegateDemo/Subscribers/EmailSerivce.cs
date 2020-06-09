using EventDelegateDemo.Publisher;
using Persistence.Model;
using System;

namespace EventDelegateDemo.Subscribers
{
    static class EmailSerivce
    {
        public static void OnProductUpdated(Product product, ProductEventArgs e)
        {
            // Alert When Product Comes Back in Stock
            //var recipients = new CustomerEmailAlertService().GetRecipients(product.ProductID);

            Console.WriteLine($"[Email Alert] '{product.ProductName}' is back in stock ({e.ModifiedAt}).");
        }
    }
}
