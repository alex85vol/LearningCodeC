using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDraw
{
    class SetPosition : IDraw
    {
        public void drawFigure(int a, int b, int j)
        {
            
            Turtle.PenUp();
            Turtle.Move(2*a/3);
            Turtle.Turn(b);
            Turtle.Move(a/3);
            Turtle.PenDown();



        }
    }
}
