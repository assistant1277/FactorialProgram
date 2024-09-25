using FactorialProgram.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to get factorial ");
            int inputNumber = int.Parse(Console.ReadLine());
            Factorial.CheckAndPrintFactorial(inputNumber);
            Console.ReadKey();
        }
    }
}
