using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);
        }
    }
}
