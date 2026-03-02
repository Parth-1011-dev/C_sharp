using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p, r, n, i;

            Console.WriteLine("Enter value of Principle:");
             p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  rate value ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter year value");
             n = float.Parse(Console.ReadLine());
            i = p * r * n;
            i = i / 100;
            Console.WriteLine("simple interest: " + i);  

        }
    }
}
