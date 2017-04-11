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
            double changeByDecadeZulu = 1.1;
            for (int i = 0; zulu > 0; i++ )
            {
                zulu = zulu * 22.7;
                Console.WriteLine("For {} decade value is {1} ", zulu, changeByDecadeZulu);
            }
            Console.ReadKey();
        }
    }
}
