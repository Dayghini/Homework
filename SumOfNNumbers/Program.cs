using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 1;

            for (int i = 1; i <= 100; i++)
            {
                decimal temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = secondNumber + temp;
                Console.WriteLine("{0}: {1}", i, firstNumber);
            }
        }
    }
}
