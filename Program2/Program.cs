using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter value of A");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of B");
            float b = float.Parse(Console.ReadLine());
            float c = a + b;
            Console.WriteLine("Ans1:" + c); 
            float d = a + b;
            Console.WriteLine("Ans2:" + d);
            float e = a + b;
            Console.WriteLine("Ans3:" + e);
            float f = a + b;
            Console.WriteLine("Ans4:" + f);       
        }
    }
}
