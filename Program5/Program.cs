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
            constructor c1 = new constructor();
            c1.calculate();
            c1.Display();

            constructor c2 = new constructor(30, 40);
            c2.calculate();
            c2.Display();
        }
    }
}
