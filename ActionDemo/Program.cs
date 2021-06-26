using System;
using System.Linq;

namespace ActionDemo
{
    /// <summary>
    /// Action oints to a method(s) that has a parameter(s) and does not return a value
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Named Method
            Action<string> print = new Action<string>(WriteMessage);
            // If the method being called is static, Target equals null.
            var targetIsNull = print.Target;

            //simpler way
            var instance = new Notifier();
            Action<string> notify = instance.Notify;
            // If the method being called is an instance (not static), Target equals an object that represents the method.
            var targetIsNotNull = notify.Target;

            print("Hello from Action");

            //Multicast Delegates
            print += WriteMessage;
            //print -= WriteMessage;

            //Anonymous Method/Inline Delegate
            Action<string> printMessage = delegate (string message)
            {
                Console.WriteLine(message);
            };
            printMessage("Hello from Anonymous method or inline delegate");

            //Lambda Expression without parameter
            Action printWelcome = () => Console.WriteLine("Welcome");
            printWelcome();

            //Lambda Expression with parameters
            Action<int, int> printSum = (num1, num2) => Console.WriteLine(num1 + num2);
            printSum(2, 3);


            Action<int> printNumber = num => Console.WriteLine(num);
            var numbers = Enumerable.Range(1, 10).ToList();
            numbers.ForEach(printNumber);
            numbers.ForEach(delegate (int value) { Console.WriteLine(value); });


        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
