using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class constructor
    {
        int l, w, area;

        public constructor()
        {
            l = 10;
            w = 20;
        }

        public constructor(int l1, int w1)
        {
            l = l1;
            w = w1;
        }

        public void calculate()
        {
            area = l * w;
        }

        public void Display()
        {
            Console.WriteLine("area is --> " + area);
        }
    }
}
