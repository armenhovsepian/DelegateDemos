using Persistence.Data;
using Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FuncDemo
{
    /// <summary>
    /// Func points to a method(s) that return a value.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProductRepository();

            //Named Method
            Func<double, double> calculatePowTwo = new Func<double, double>(PowTwo);
            //simpler way
            //Func<double, double> calculatePowTwo = PowTwo;

            //Multicast Delegates
            calculatePowTwo += PowTwo;
            Console.WriteLine(calculatePowTwo(4));

            //Anonymous Method/Inline Delegate
            Func<double, double> calculateCircleArea = delegate (double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            };
            Console.WriteLine(calculateCircleArea(10));

            //Lambda Expression without parameter
            Func<long> unix = () => DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Console.WriteLine(unix());

            //Lambda Expression with parameters
            Func<double, double, int, double> calculateCompoundInterest =
                (principle, interestRate, noOfYears) =>
                    (principle) * Math.Pow((1 + (interestRate) / 100), noOfYears);
            Console.WriteLine(calculateCompoundInterest(10000, 0.5, 2));


            IEnumerable<Product> products = Enumerable.Empty<Product>();
            //Perform criteria in Memory
            Func<Product, bool> isLessThan100 = product => product.UnitPrise <= 100;
            products = repository.Products.Where(isLessThan100).ToList();

            var exists = repository.Products.Any(isLessThan100);

            //Perform criteria in Database
            Expression<Func<Product, bool>> isGreaterThan100 =
                product => product.UnitPrise > 100;
            products = repository.Products.Where(isGreaterThan100).ToList();
        }

        static double PowTwo(double value)
        {
            return Math.Pow(value, 2);
        }
    }
}
