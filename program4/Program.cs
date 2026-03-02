using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compund interest");
            Console.WriteLine("Enter value of Principle:");
            float p =float.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of Rate of interest:");
            float r =float.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of No of years:");
            float n =float.Parse(Console.ReadLine());
            double amount = p * Math.Pow(1 + r/100,n);
            double compundinterest = amount - p;
            Console.WriteLine("compund interest:" + compundinterest);
        }
    }
}
