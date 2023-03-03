using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = "This is a \u0050";
            string n = "Accidentaly made a \u0070";
            string b = @"varias strigs \u0075";
            string c = @"Algumas strigs \u0055";

            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
