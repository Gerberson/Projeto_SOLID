﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Triangulo sobrescrevendo Figura");
        }
    }
}
