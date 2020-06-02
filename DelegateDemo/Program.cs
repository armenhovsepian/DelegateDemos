using System;

namespace DelegateDemo
{
    class Program
    {
        public delegate void Print(string message);
        static void Main(string[] args)
        {
            //Named Method
            Print writeMessage = WriteMessage;
            writeMessage("Hello from Named Method");

            //Anonymous method or Inline delegate
            Print printMassage = delegate (string message) { 
                Console.WriteLine(message); 
            };
            printMassage("Hello from Anonymous method or Inline delegate");

            //Lambda Expression
            Print print = (message) => Console.WriteLine(message);
            print("Hello from Lambda Expression");
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
