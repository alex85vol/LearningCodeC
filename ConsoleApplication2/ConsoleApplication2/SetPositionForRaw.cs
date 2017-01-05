using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDraw
{
    class SetPositionForRaw : IDraw
    {
        public void drawFigure(int a, int b, int j)
        {
            Turtle.PenUp();
            Turtle.TurnLeft();
            Turtle.Move(8.3 * a);
            Turtle.TurnLeft();
            Turtle.Move(2 * a);
            Turtle.Turn(2 * b);
            Turtle.PenDown();

        }
    }
}
