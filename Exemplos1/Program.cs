using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado1 = Somar(100);
            var resultado2 = Somar(100, 200);
            var resultado3 = Somar(100, 200, 300);
            var resultado4 = Somar(100, 200, 300, 400); 
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
        }

        //PARAMENTRO OPCIONAIS DEVE VIR DEPOIS DO PRIMEIRO PARAMENTRO OBRIGATORIO
        static public int Somar(int x, int y = 10, int z = 20, int w = 30)
        {
            return x + y + z + w;
        }
    }
}
