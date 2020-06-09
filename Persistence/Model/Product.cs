using System;

namespace Persistence.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrise { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
