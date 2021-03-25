using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your nickname:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}", nombre);
        }
    }
}
