﻿using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            char P ='\u0050';
            char p ='\u0070';
            char u ='\u0075';
            Console.WriteLine("Variaveis inteiras");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Unicode");
            Console.WriteLine(P + " " + "u0050");
            Console.WriteLine(p + " " + "u0070");
            Console.WriteLine(u + " " + "u0075");
        }
    }
}
