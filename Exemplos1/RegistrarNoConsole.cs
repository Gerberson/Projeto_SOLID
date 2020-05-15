using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"RegistrarNoConsole : {mensagem}");
        }
    }
}
