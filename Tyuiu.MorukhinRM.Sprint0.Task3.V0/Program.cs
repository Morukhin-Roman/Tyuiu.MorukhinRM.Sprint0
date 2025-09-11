using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorukhinRM.Sprint0.Task3.V0.Lib;
namespace Tyuiu.MorukhinRM.Sprint0.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(8, 8));
            Console.ReadKey();
        }
    }
}
