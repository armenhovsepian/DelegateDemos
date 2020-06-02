using Persistence.Data;
using Persistence.Model;
using System;
using System.Linq;

namespace PredicateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Named Method
            var rndId = new Random().Next(10);
            var product = new ProductService().GetById(rndId);
            Predicate<Product> isLessThan100 = IsLessThan100;
            Console.WriteLine(isLessThan100(product));

            //Anonymous Method/Inline Delegate
            Predicate<int> IsPositive = delegate (int num)
            {
                return num >= 0;
            };

            //Lambda Expression with parameter
            var rndValue = new Random().Next(10);
            Predicate<int> IsEven = num => num % 2 == 0;
            Console.WriteLine(IsEven(rndValue));

            //Perform criteria in Memory
            Predicate<Product> FindById = product => 
                product.ProductID == new Random().Next(10);
            var res = new ProductService().Products.ToList().Find(FindById);
        }


        static bool IsLessThan100(Product product)
        {
            return product.UnitPrise <= 100;
        }


    }
}
