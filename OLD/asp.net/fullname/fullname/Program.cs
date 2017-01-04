using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string fullName;

            Console.WriteLine("het you !");

            firstName = GetUserInput("Enter your first name: ");
            lastName = GetUserInput("Enter your last name: ");
            fullName = GetFullName(firstName, lastName);
            DispalyGreeting(fullName);
        }
        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static string GetFullName(string firstName, string lastName)
        { 
            return string.Format("{0} {1}",firstName,lastName);
        }
        static void DispalyGreeting(string name)
        {
            Console.WriteLine("Your full name is {0}.", name);
        }
    }
}
