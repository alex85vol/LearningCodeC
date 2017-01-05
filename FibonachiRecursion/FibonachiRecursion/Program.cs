using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiRecursion
{
    class Program
    {
       /* static int fibonachiNumbers(int n)
        {
            if ( n < 2 ) return 1;
            else return fibonachiNumbers(n - 1) + fibonachiNumbers(n - 2);
        }*/
        static void Main(string [] args)
        {
            /*for ( int i = 1; i < 50; i++ )
            {
                Console.WriteLine("{0}", fibonachiNumbers(i));
            }*/

            int u = 1, v = 1;
            for ( int i = 0; i < 40; i++ )
            {
                Console.WriteLine("{0}", u);
                int w = u + v;
                u = v;
                v = w;
            }

            Console.ReadKey();
            
        }
    }
}
