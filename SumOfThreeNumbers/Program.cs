using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = Int32.Parse(Console.ReadLine());
            
            int b = Int32.Parse(Console.ReadLine());
         
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result is {0}", a + b + c);
        }
    }
}
