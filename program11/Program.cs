using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            Console.Write("Enter the starting number: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPrime numbers between " + start + " and " + end + " are:\n");

            // Loop through all numbers between start and end
            for (int number = start; number <= end; number++)
            {
                int count = 0;

               
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }

              
                if (count == 2)
                {
                    Console.Write(number + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
