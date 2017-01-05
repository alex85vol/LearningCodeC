using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDraw
{
    class Colorize
    {
        static Random Rnd = new Random();

        public static void Colorized()
        {
            var r = Rnd.Next(1, 10);
            if ( r < 3 ) GraphicsWindow.PenColor = "Blue";
            else if ( r < 5 ) GraphicsWindow.PenColor = "Red";
            else if ( r < 7 ) GraphicsWindow.PenColor = "Yellow";
            else GraphicsWindow.PenColor = "Black";
        }
    }
}
