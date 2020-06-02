﻿using System;

namespace ActionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Named Method
            Action<string> Print = new Action<string>(WriteMessage);
            //Short 
            //Action<string> Print = WriteMessage;
            Print("Hello from Action");

            //Anonymous method or Inline delegate
            Action<string> PrintMessage = delegate (string message) { Console.WriteLine(message); };
            PrintMessage("Hello from Anonymous method or Inline delegate");

            //Lambda Expression without parameter
            Action PrintWelcome = () => Console.WriteLine("Welcome");
            PrintWelcome();

            //Lambda Expression with parameters
            Action<int, int> PrintSum = (num1, num2) => Console.WriteLine(num1 + num2);
            PrintSum(2, 3);
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}