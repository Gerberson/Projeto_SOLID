using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrarOcorrencias registrarOcorrencias = new RegistrarOcorrencias();

            registrarOcorrencias.RegistrarNoConsole("Registrei no console");
            registrarOcorrencias.RegistrarNoArquivo("Arquivo", "Registrei no arquivo.");
            registrarOcorrencias.RegistrarJSON("JSON", "Registrei no JSON.");
        }
    }
}
