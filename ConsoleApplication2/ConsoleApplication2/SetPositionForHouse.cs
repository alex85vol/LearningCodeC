using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HouseDraw
{
    class SetPositionForHouse : IDraw
    {
        public void drawFigure(int a, int b, int j) {
            Turtle.PenUp();
            Turtle.Turn(2*b);
            Turtle.Move(a);
            Turtle.TurnRight();
            Turtle.Move(0.32 * a);
            Turtle.Turn(2 * b);
            Turtle.PenDown();
        }
    }
}
