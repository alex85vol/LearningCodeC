using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveConsole
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Hello. What is your name?");
            Console.WriteLine();
            string name;
            do
            {
                name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Hello " + name);
                Console.WriteLine("I'm pleased to see you " + name); 
            } while ( name != null );
        }
    }
}
