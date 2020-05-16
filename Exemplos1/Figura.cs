using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Exemplos1
{
    class Figura
    {
        protected string Nome { get; set; }

        public virtual void Desenhar() 
        {
            Console.WriteLine("Executando classe Figura");
        }
    }
}
