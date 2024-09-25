using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram.model
{
    public class Factorial
    {
        public static int CalculateFactorialRecursive(int number)
        {
            if(number <= 1)
                return 1;
            return number * CalculateFactorialRecursive(number - 1);
        }
        public static int CalculateFactorialIterative(int number)
        {
            int factorial = 1;
            for(int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static void CheckAndPrintFactorial(int number)
        {
            int factorialRecursive = CalculateFactorialRecursive(number);
            Console.WriteLine($"factorial of {number} with recursive approach is {factorialRecursive}");

            int factorialIterative = CalculateFactorialIterative(number);
            Console.WriteLine($"factorial of {number} with iterative approach is {factorialIterative}");
        }
    }
}
