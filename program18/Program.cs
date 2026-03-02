using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program18
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = new int[5];

            
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int max = numbers[0];

           
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

           
            Console.WriteLine("Maximum number is: " + max);

            Console.ReadLine();
        }
    }
}
