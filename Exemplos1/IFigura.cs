using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    interface IFigura
    {
        string Nome { get; set; }
        void Desenhar();
        void Identificar();
        void Duplicar();
    }
}
