using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of the circle");
            double r = float.Parse(Console.ReadLine());
            double a = 3.14 * r * r;
            Console.WriteLine("Area of the circle:" +a);
        }
    }
}
