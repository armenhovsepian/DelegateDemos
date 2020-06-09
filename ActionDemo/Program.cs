using System;

namespace ActionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Named Method
            Action<string> print = new Action<string>(WriteMessage);
            //simpler way
            //Action<string> print = WriteMessage;
            print("Hello from Action");

            //Multicast Delegates
            print += WriteMessage;
            //print -= WriteMessage;

            //Anonymous Method/Inline Delegate
            Action<string> printMessage = delegate (string message) { 
                Console.WriteLine(message); 
            };
            printMessage("Hello from Anonymous method or inline delegate");

            //Lambda Expression without parameter
            Action printWelcome = () => Console.WriteLine("Welcome");
            printWelcome();

            //Lambda Expression with parameters
            Action<int, int> printSum = (num1, num2) => Console.WriteLine(num1 + num2);
            printSum(2, 3);
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void WriteMessage2(string message)
        {
            Console.WriteLine(message);
        }
    }
}
