using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class Circulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Circulo sobrescrevendo Figura");
        }
    }
}
