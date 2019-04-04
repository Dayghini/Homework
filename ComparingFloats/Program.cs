using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two floating-point numbers to compare ");

            double Number1 = double.Parse(Console.ReadLine());
            double Number2 = double.Parse(Console.ReadLine());

            

            if (Math.Abs(Number1 - Number2) < 0.000001)
            {
           
                Console.WriteLine("The two numbers are equal with precision 0.000001");
            }
            else
            {
                Console.WriteLine("The two numbers are NOT equal with precision 0.000001");
            }
        }
    }
}
