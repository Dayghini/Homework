using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCompape
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else if (numTwo > numOne)
            {
                Console.WriteLine(numTwo);
            }
            else
            {
                Console.WriteLine(numOne);
            }
        }
    }
}
