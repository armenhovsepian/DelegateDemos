using EventDelegateDemo.Publisher;
using Persistence.Model;
using System;

namespace EventDelegateDemo.Subscribers
{
    static class SmsService
    {
        public static void OnProductUpdated(Product product, ProductEventArgs e)
        {
            // Alert When Product Comes Back in Stock
            //var recipients = new CustomerSmsAlertService().GetRecipients(product.ProductID);

            Console.WriteLine($"[SMS Alert] '{product.ProductName}' is back in stock ({e.ModifiedAt}).");
        }
    }
}
