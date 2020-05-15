using System;

namespace Exemplos1
{
    public class Professor : IDisposable
    {
        public string Nome { get; set; }

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void Dispose()
        {
            
        }
    }
}