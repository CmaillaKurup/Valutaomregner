using System;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double usDollars = 0.16;
            double britisk = 0.12;
            double euro = 0.13;
            double svensk = 1.38;

            Console.WriteLine("US Dollars = " + (input + usDollars));
            Console.WriteLine("Britiske Pund = " + (input + britisk));
            Console.WriteLine("Euro = " + (input+ euro));
            Console.WriteLine("Svensk = " + (input + svensk));
        }
    }
}
