using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName2
{
    class Program
    {
        //Simple Consola App with loops

        static void Main(string [] args)
        {
            String name;
            do
            {
                Console.WriteLine("Hello! Pleasse enter your name: ");
                name = Console.ReadLine();
                if ( name == "Bob" ) Console.WriteLine("Fuck you " + name);
                else if ( name == "Alex" ) Console.WriteLine("Hello " + name + " . I realy happy to meet you again!");
                else Console.WriteLine("Hi " + name); 
            } while ( name != null );
             
        }
    }
}
