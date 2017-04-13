using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction_001
{
    class Program
    {
        static void Main(string[] args)
        {
            double zulu = 23.8;
            double changeByDecadeZulu = 0.011;
            for (int i = 0; zulu > 0.01; i++ )
            {
                Console.WriteLine("For the current {0} decade value is {1}, year {2} ", zulu, changeByDecadeZulu, i * 10);
                zulu = zulu - zulu * changeByDecadeZulu;
                
            }
            //a0 = 100, t = 0.1
            //a1 = a0 - (a0 * 0.1)//100-10 = 90
            //a2 = a1 - (a1 * 0.1)//90 - 9 = 81
            //a3 = a2 - (a2 * 0.1)//81 - 8.1 = 72.9

            Console.ReadKey();
        }
    }
}
