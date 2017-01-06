using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KohSnow
{
    class DrawLine
    {
        static Random rnd = new Random();
        public static void drawLine(int len)
        {
            var n = rnd.Next(3, 7);
            var turn = new int [n];
            var l = len / n;
            for ( int i = 0; i < n; i++ )
            {
                var a = rnd.Next(-30, 30);
                turn [i] = a;
                Turtle.Turn(a);
                Turtle.Move(l);
            }

            Turtle.Turn(180);
            for ( int i = n - 1; i >= 0; i-- )
            {
                Turtle.Move(l);
                Turtle.Turn(-turn [i]);
            }
            Turtle.Turn(180);

        }
    }
}
