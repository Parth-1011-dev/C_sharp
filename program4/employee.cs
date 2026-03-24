using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    internal class employee
    {
        int empno;
        string empname;
        string empcontact;

        public void GetDetails()
        {
            Console.Write("Enter Employee Number: ");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            empname = Console.ReadLine();

            Console.Write("Enter Employee Contact: ");
            empcontact = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("\nEmployee Details");
            Console.WriteLine("Employee Number: " + empno);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Employee Contact: " + empcontact);
        }
    }
}
