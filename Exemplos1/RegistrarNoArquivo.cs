using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class RegistrarNoArquivo : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"RegistrarNoArquivo : {mensagem}");
        }
    }
}
