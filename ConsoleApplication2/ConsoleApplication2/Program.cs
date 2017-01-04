using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace HouseDraw
{
    class Program
    {
        static void Main(string [] args)
        {

            var a = 100;
            var b = 90;
            Turtle.Speed = 9;
            SetPosition setPosition = new SetPosition();
            DrawRectangle drawRectangle = new DrawRectangle();
            DrawTriangle drawTriangle = new DrawTriangle();
            
            drawRectangle.drawFigure(a, b, 5);
            drawTriangle.drawFigure(a, b, 0);
            setPosition.drawFigure(a, b, 0);
            drawRectangle.drawFigure(a/3, b, 4);
            




        }
    }
    }

