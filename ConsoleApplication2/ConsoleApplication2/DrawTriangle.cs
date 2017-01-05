using Microsoft.SmallBasic.Library;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HouseDraw
{
    class DrawTriangle : IDraw
    {
        

        public void drawFigure(int a, int b, int j)
        {
            Colorize.Colorized();
            Turtle.Turn(b - 150);
            Turtle.Move(a);
            Turtle.Turn(b + 30);
            Turtle.Move(a);
            Turtle.Turn(b - 60);
        }
    }
}
