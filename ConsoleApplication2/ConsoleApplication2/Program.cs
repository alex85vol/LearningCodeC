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

            for (int y = 0; y < 3; y++)
            {
                for (int i = 0; i < 5; i++)
                {
                    DrawHouse.drawHouse(a, b);
                    SetPositionForHouse setPositionForHouse = new SetPositionForHouse();
                    setPositionForHouse.drawFigure(a, b, 0);
                }
                SetPositionForRaw setPositionRow = new SetPositionForRaw();
                setPositionRow.drawFigure(a, b, 0);
            }
        }
    }
    }

