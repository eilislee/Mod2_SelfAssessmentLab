using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {

            int row = 0;

            for (row = 0; row < 8; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine("X O X O X O X O");
                }
                else  // the remainder was not 0 so the value entere is an odd number.
                {
                    Console.WriteLine("O X O X O X O X");
                }
            }


            Console.ReadLine();
        }
    }
}
