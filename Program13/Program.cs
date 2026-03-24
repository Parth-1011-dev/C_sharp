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
            int[] arr = new int[5];
 int min, i;

 Console.WriteLine("Enter 5 numbers:");

 for (i = 0; i < 5; i++)
 {
     arr[i] = int.Parse(Console.ReadLine());
 }

 min = arr[0];

 for (i = 1; i < 5; i++)
 {
     if (arr[i] < min)
     {
         min = arr[i];
     }
 }

 Console.WriteLine("Minimum number is: " + min);
        }
    }
}
