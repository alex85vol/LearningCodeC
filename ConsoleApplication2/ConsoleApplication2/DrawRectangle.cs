using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDraw
{
    class DrawRectangle : IDraw
    {
        
        public void drawFigure(int a, int b, int j)
        {
            for ( var i = 1; i <= j; i++ )
            {
                Colorize.Colorized();
                Turtle.Move(a);
                Turtle.Turn(b);
                                
            }
        }

       
    }
}
