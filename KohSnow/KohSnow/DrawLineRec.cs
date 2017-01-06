using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KohSnow
{
    class DrawLineRec
    {
        static Random rnd = new Random();
        public static void drawLineR(int len)
        {
            var n = rnd.Next(3, 7);
            drawLineRec(len / n, n);

        }
        public static void drawLineRec(int len, int n)
        {
            if ( n > 0 )
            {
                var a = rnd.Next(-30, 30);
                Turtle.Turn(a);
                Turtle.Move(len);
                drawLineRec(len, n - 1);
                Turtle.Turn(180);
                Turtle.Move(len);
                Turtle.Turn(-a);
                Turtle.Turn(180);
            }
        }
    }
}
