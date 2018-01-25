using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int num;
            int choice;
            int numTimes = 0; ;
            int counter = 0;

            Console.WriteLine("Hello World!");

            Console.WriteLine("I am thinging of a number between 0 and 100");
            num = r.Next(0, 100);
            Console.WriteLine("Can you guess?");
            while (counter != 1)
            {
                choice = Console.Read();

                if (choice < num)
                {
                    Console.WriteLine("To low");
                }
                else if (choice > num)
                {
                    Console.WriteLine("To High");
                }
                else if (choice == num)
                {
                    Console.WriteLine("Just right");
                }
                numTimes++;
                Console.WriteLine("Press 0 if you would like to try again and 1 if you wold not");
                counter = Console.Read();
            }
            Console.WriteLine("It took you this many times");
            Console.WriteLine(numTimes);
        }
    }
}
