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
            var resultado5 = Somar(100, 200, 300, 400, 500); 
            var resultado6 = Somar(100, 200, 300, 400, 500, 600); 
            var resultado7 = Somar(100, 200, 300, 400, 500, 600, 700); 
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
            Console.WriteLine(resultado5);
            Console.WriteLine(resultado6);
            Console.WriteLine(resultado7);
        }

        //PARAMENTRO OPCIONAIS DEVE VIR DEPOIS DO PRIMEIRO PARAMENTRO OBRIGATORIO
        //UTILIZANDO O PARAMS NÃO PRECISAMOS DEFINIR VALOR PARADRÃO
        static public int Somar(int x, params int[] numeros)
        {
            int result = 0;
            foreach (int num in numeros)
            {
                result += num;
            }

            return x + result;
        }
    }
}
