using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = number;
            
            while (temp > 0)
            {
                int digit = temp % 10;  // Get last digit
                sum += digit;           // Add digit to sum
                temp /= 10;             // Remove last digit
            }
            
            Console.WriteLine("The sum of the digits of " + number + " is: " + sum);
     
            Console.ReadLine();
        }   
    }
}
