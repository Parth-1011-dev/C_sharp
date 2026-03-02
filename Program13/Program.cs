using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            string revname = "";
            int i;
            for(i = name.Length-1; i >=0; i--)
            {
                revname = revname + name[i];
            }
            if (name == revname)
            {
                Console.WriteLine("NAME IS PALINDROME");
            }
            else
            {
                Console.WriteLine("NAME IS NOT PALINDROME");    
            }
        }
    }
}
