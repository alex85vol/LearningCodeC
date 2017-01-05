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
        public static void basicDraw(int len, int angle)
        {
            Turtle.Turn(2 * angle);
            Turtle.Move(len);
            Turtle.Turn(-angle);
            Turtle.Move(len);
            Turtle.Turn(2 * angle);
            Turtle.Move(len);
            Turtle.Turn(-angle);
            Turtle.Move(len);
        }
    }
}
