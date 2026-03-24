using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] j1 = new int[3][];
            j1[0] = new int[3];
            j1[1] = new int[4];
            j1[2] = new int[1];


            for (int i=0; i<j1.Length; i++)
            {
                for (int j=0; j < j1[i].Length; j++)
                {
                    Console.WriteLine("enter value: ");
                    j1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nJagged Array Elements: ");

            for (int i = 0; i < j1.Length; i++)
            {
                for (int j = 0; j < j1[i].Length; j++)
                {
                    Console.Write(j1[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
