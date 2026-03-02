using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n=int.Parse(Console.ReadLine());
            int n1=0; int n2=1; int n3=1;
            Console.WriteLine(n1 + "  ");
            Console.WriteLine(n2 + "  ");
            do
            {
                n3 = n1 + n2;
                if (n3 > n)
                    break;
                    Console.WriteLine(n3 + "  ");
                n1 = n2;
                n2 = n3;
            }
            while (true);
        }
    }
}

