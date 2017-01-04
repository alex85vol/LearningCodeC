using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ang1 = 90;
            int ang2 = 60;
            int ang3 = 120;
            int ang4 = 270;
            int ang5 = 180;

            int len1 = 200;
            int len2 = 50;
            int len3 = 100;

            Turtle.Speed = 5;
            Turtle.Turn(ang5);
            Turtle.PenUp();
            Turtle.Move(len1);
            Turtle.Turn(ang4);
            Turtle.PenDown();
            Turtle.Move(len1);
            Turtle.Turn(ang1);
            Turtle.Move(len1);
            Turtle.Turn(ang1);
            Turtle.Move(len1);
            Turtle.Turn(ang2);
            Turtle.Move(len2);

        }
    }
}
