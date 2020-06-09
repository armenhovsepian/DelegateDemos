using System;

namespace DelegateDemo
{
    class Program
    {
        public delegate void PrintDelegate(string message);
        static void Main(string[] args)
        {
            //Named Method
            PrintDelegate delInstance = new PrintDelegate(WriteMessage);
            //simpler way
            PrintDelegate writeMessage = WriteMessage;
            writeMessage("Hello from Named Method");

            //Anonymous Method/Inline Delegate
            PrintDelegate printMassage = delegate (string message) { 
                Console.WriteLine(message); 
            };
            printMassage("Hello from Anonymous method or Inline delegate");

            //Lambda Expression
            PrintDelegate print = (message) => Console.WriteLine(message);
            print("Hello from Lambda Expression");
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
