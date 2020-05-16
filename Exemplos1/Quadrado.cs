using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class Quadrado : Figura
    {
        public Quadrado(string nome) : base(nome)
        {

        }
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando o {Nome}...");
            Duplicar();
        }

        public override void Identificar()
        {
            Console.WriteLine($"Sou o {Nome}...");
        }
    }
}
