using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Transactions;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>
            {
                new Triangulo(),
                new Circulo()
            };

            foreach (var figura in figuras)
            {
                figura.Desenhar();
            }
        }
    }
}
