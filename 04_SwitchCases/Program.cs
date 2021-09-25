using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello World");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;

            switch(today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!!");
                    break;
            }

            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feelingValue = Console.ReadLine();
            switch(feelingValue)
            {
                case "1":
                    Console.WriteLine("I hope you feel better soon.");
                    break;
                case "2":
                    Console.WriteLine("I'm sorry to hear that.");
                    break;
                case "3":
                    Console.WriteLine("That's better than nothing!");
                    break;
                case "4":
                    Console.WriteLine("That's good!");
                    break;
                case "5":
                    Console.WriteLine("That's great!");
                    break;
                default:
                    Console.WriteLine("That's not a number from 1-5.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
