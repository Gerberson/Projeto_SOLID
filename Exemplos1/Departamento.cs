using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class Departamento : IDisposable
    {
        public string Nome { get; set; }
        public Escola Escola { get; set; }

        internal Departamento(Escola escola, string nome)
        {
            Escola = escola;
            Nome = nome;
        }

        public void Dispose()
        {
            //DESTROI O DEPARTAMENTO
        }
    }
}
