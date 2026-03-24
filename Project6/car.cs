using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    internal class car:vehicle
    {
        string model_type, company_name;

        public void get_car()
        {
            Console.WriteLine("Enter model_type: ");
            model_type = Console.ReadLine();

            Console.WriteLine("Enter Company_name: ");
            company_name = Console.ReadLine();
        }

        public void show_car()
        {
            Console.WriteLine("Model type: " +  model_type);
            Console.WriteLine("Company name: " + company_name);
        }
    }
}
