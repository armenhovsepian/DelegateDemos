using System;

namespace EventDelegateDemo.Publisher
{
    public class ProductEventArgs : EventArgs
    {
        public DateTimeOffset ModifiedAt { get; set; }
    }
}
