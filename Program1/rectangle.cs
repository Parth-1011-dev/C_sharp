using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class rectangle
    {
        int l, w, area;

        public void getdata()
        {
            Console.WriteLine("Enter length: ");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            w = int.Parse(Console.ReadLine());
        }

        public void calculate()
        {
            area = l * w;
        }

        public void display()
        {
            Console.WriteLine("Area: " + area);
        }
    }
}
