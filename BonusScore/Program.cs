using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score <= 3 && score > 0)
            {
                score = score * 10;
                Console.WriteLine(score);
            }
            else if (score >= 4 && score <= 6)
            {

                score = score * 100;
                Console.WriteLine(score);
            }
            else if (score >= 7 && score <= 9)
            {
                score = score * 1000;
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
