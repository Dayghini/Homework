using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 33; i < 127; i++)
            {
                char a = (char)i;
                Console.Write(a);
            }

            Console.WriteLine();
        }
    }
}
