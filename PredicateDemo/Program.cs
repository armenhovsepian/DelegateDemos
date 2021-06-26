using Persistence.Data;
using Persistence.Model;
using System;
using System.Linq;

namespace PredicateDemo
{
    /// <summary>
    /// Predicate points to a method(s) that return a Boolean value. (a type/ extension of Func) 
    /// Can use for checking purposes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProductRepository();

            //Named Method
            var rndId = new Random().Next(10);
            var product = repository.GetById(rndId);
            Predicate<Product> isLessThan100 = IsLessThan100;
            Console.WriteLine(isLessThan100(product));

            //Anonymous Method/Inline Delegate
            Predicate<int> isPositive = delegate (int num)
            {
                return num >= 0;
            };

            //Lambda Expression with parameter
            var rndValue = new Random().Next(10);
            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine(isEven(rndValue));

            //Perform criteria in Memory
            Predicate<Product> findById = product =>
                product.ProductID == new Random().Next(10);
            var products = repository.GetAll().Find(findById);

            var isExist = repository.GetAll().Any(IsLessThan100);
        }


        static bool IsLessThan100(Product product)
        {
            return product.UnitPrise <= 100;
        }


    }
}
