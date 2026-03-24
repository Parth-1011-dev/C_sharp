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
            employee emp = new employee();
            emp.GetDetails();
            emp.Display();

            Console.ReadLine();
        }
    }
}
