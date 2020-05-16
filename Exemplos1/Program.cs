using System;
using System.Diagnostics;
using System.Transactions;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado("Quadrado");
            quadrado.Identificar();
            quadrado.Desenhar();

            Console.WriteLine();

            Triangulo triangulo = new Triangulo("Triangulo");
            triangulo.Identificar();
            triangulo.Desenhar();
            triangulo.Duplicar();
        }
    }
}
