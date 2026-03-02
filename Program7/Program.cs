using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int a = int.Parse(Console.ReadLine());
            if (a < 12)
            {
                Console.WriteLine("you are a kid");
            }
            else if (a >= 12 && a <= 17)
            {
                Console.WriteLine("Teenager");
            }
            else if (a >= 18 && a <= 60)
            {
                Console.WriteLine("you are a adult");
            }
            else
            {
                Console.WriteLine("you are a senior citizen");
            }
        }
    }

}