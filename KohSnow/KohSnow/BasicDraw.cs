using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace KohSnow
{
    class BasicDraw
    {
        public static void basicDraw(int len, int angle, int n)
        {
            if ( n == 0 ) Turtle.Move(len);
            else
            {
                basicDraw(len / 3, angle, n - 1);
                Turtle.Turn(-angle);
                basicDraw(len / 3, angle, n - 1);
                Turtle.Turn(2 * angle);
                basicDraw(len / 3, angle, n - 1);
                Turtle.Turn(-angle);
                basicDraw(len / 3, angle, n - 1);
            }
        }
    }
}
