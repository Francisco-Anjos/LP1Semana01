using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            char P ='\u0050';
            char p ='\u0070';
            char u ='\u0075';
            float h =5.59f;
            double j = 60.40e-40;
            bool z = false;
            bool a = true;
            Console.WriteLine("Variaveis inteiras");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Unicode");
            Console.WriteLine(P + " " + "u0050");
            Console.WriteLine(p + " " + "u0070");
            Console.WriteLine(u + " " + "u0075");
            Console.WriteLine("Reais");
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine("Booleanos");
            Console.WriteLine(z);
            Console.WriteLine(a);
        }
    }
}
