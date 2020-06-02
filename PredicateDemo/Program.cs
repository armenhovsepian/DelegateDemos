using PredicateDemo.Data;
using PredicateDemo.Model;
using System;
using System.Collections.Generic;

namespace PredicateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Named Method
            var rndId = new Random().Next(10);
            var user = new UserService().GetUserById(rndId);
            Predicate<User> IsAdmin = IsAdminUser;
            Console.WriteLine(IsAdmin(user));

            //Anonymous method or Inline delegate
            Predicate<int> IsPositive = delegate (int num)
            {
                return num >= 0;
            };

            //Lambda Expression with parameter
            var rndValue = new Random().Next(10);
            Predicate<int> IsEven = num => num % 2 == 0;
            Console.WriteLine(IsEven(rndValue));

            var users = new List<User>();
            var result = users.Find(IsAdmin);
        }


        static bool IsAdminUser(User user)
        {
            return user.Type == UserType.Administrator;
        }
    }
}
