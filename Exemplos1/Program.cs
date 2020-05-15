using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrarOcorrencias registrarOcorrencias = new RegistrarOcorrencias(new RegistrarNoConsole());
            registrarOcorrencias.Registrar("Estou registrando console.");

            RegistrarOcorrencias registrarOcorrencias2 = new RegistrarOcorrencias(new RegistrarNoArquivo());
            registrarOcorrencias2.Registrar("Estou registrando no arquivo.");


        }
    }
}
