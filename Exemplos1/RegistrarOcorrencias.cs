using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class RegistrarOcorrencias
    {
        public void RegistrarNoConsole(string mensagem)
        {
            Console.WriteLine($"{mensagem} : {DateTime.Now}");
        }

        public void RegistrarNoArquivo(string arquivo, string mensagem)
        {
            Console.WriteLine($"{arquivo} - {mensagem}");
        }

        public void RegistrarJSON(string arquivo, string mensagem)
        {
            Console.WriteLine($"{arquivo} - {mensagem}");
        }
    }
}
