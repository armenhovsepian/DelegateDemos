using Persistence.Data;
using Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FuncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Named Method
            Func<double, double> CalcTwice = new Func<double, double>(Twice);
            //Short
            //Func<double, double> CalcTwice = Twice;
            Console.WriteLine(CalcTwice(4));

            //Anonymous Method/Inline Delegate
            var pi = 3.14;
            Func<double, double> CalcCircleArea = delegate (double radius)
            {
                return radius * radius * pi;
            };
            Console.WriteLine(CalcCircleArea(10));

            //Lambda Expression without parameter
            Func<long> GetUnix = () => DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Console.WriteLine(GetUnix());

            //Lambda Expression with parameters
            Func<double, double, int, double> CalculateCompoundInterest = 
                (principle, interestRate, noOfYears) => 
                    (principle) * Math.Pow((1 + (interestRate) / 100), noOfYears);
            Console.WriteLine(CalculateCompoundInterest(10000, 0.5, 2));


            IEnumerable<Product> products = Enumerable.Empty<Product>();
            //Perform criteria in Memory
            Func<Product, bool> IsLessThan100 = 
                product => product.UnitPrise <= 100;
            products = new ProductService().Products.Where(IsLessThan100).ToList();

            //Perform criteria in Database
            Expression<Func<Product, bool>> IsLessThan100Exp = 
                product => product.UnitPrise <= 100;
            products = new ProductService().Products.Where(IsLessThan100Exp).ToList();
        }

        static double Twice(double value)
        {
            return (value * 2);
        }
    }
}
