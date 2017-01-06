using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace KohSnow
{
    class Program
    {
        static void Main(string [] args)
        {
            Turtle.Speed = 10;
            int len = 150;
            DrawLineRec.drawLineR(len);
           
        /*    for ( int i = 0; i < 15; i++ )
            {

               int angle = 60;
               int n = 4;
                 for ( int i = 0; i < 3; i++ )
                 {
                     BasicDraw.basicDraw(len, angle, n);
                     Turtle.Turn(2 * angle);
                 }

                DrawLine.drawLine(len);
                Turtle.Move(10);
                Turtle.Turn(10);
            }*/


        }
    }
}
