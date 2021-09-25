using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            int total = 1;
            while(total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            // For Loop
            int studentCount = 5;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            // Foreach Loop
            List<string> students = new List<string>();
            students.Add("Andrew");
            students.Add("Anna");
            students.Add("Colin");
            students.Add("Danny");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }

            int[] numbers = { 1, 2, 3, 900, 1000, -56 };
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Do While Loop
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            Console.ReadKey();
        }
    }
}
