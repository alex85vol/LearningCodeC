using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDraw
{
    class DrawHouse

    {
        public static void drawHouse(int a, int b)
        {
            SetPosition setPosition = new SetPosition();
            DrawRectangle drawRectangle = new DrawRectangle();
            DrawTriangle drawTriangle = new DrawTriangle();

            drawRectangle.drawFigure(a, b, 5);
            drawTriangle.drawFigure(a, b, 0);
            setPosition.drawFigure(a, b, 0);
            drawRectangle.drawFigure(a / 3, b, 4);
        }
    }
}
