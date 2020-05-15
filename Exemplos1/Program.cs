using System;
using System.Security.Cryptography.X509Certificates;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado1 = Somar(100, 200);
            var resultado2 = Somar(100, 200, 300);
            var resultado3 = Somar(1, 2, 3, 4);
            var resultado4 = Somar(new int[] { 1, 2, 3, 4 }); 
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);



        }

        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        //SOBRE CARGA DE METODOS SO É POSSIVEL SE O PARAMETRO MUDAR
        static public double Somar(double numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (int num in numeros)
            {
                resultado += num;
            }
            return resultado;
        }
    }
}
