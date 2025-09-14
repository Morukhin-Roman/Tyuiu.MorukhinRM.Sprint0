using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MorukhinRM.Sprint0.Task5.V0.Lib;
namespace Tyuiu.MorukhinRM.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(10, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 5));
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
