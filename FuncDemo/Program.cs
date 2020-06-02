using System;

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

            //Anonymous method or Inline delegate
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
            Func<double, double, int, double> CalculateCompoundInterest = (principle, interestRate, noOfYears) => (principle) * Math.Pow((1 + (interestRate) / 100), noOfYears);
            Console.WriteLine(CalculateCompoundInterest(10000, 0.5, 2));
        }

        static double Twice(double value)
        {
            return (value * 2);
        }
    }
}
