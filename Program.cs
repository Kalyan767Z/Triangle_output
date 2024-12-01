using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Uroks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Triangle size: ");
            if (int.TryParse(Console.ReadLine(), out int heith) && heith>0)
                {
                for (int j = 0; j <= heith; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int j = 0; j <= heith; j++)
                {
                    for (int k = heith; k > j; k--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
            else Console.WriteLine("Cant draw triangle");
        }
    }
}