using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToNTwoForSomeReason
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i < row; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
