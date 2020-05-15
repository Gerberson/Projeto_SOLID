using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento departamento = new Departamento("Funcionarios");

            departamento.AddProfessores("Ana Lucia");
            departamento.AddProfessores("Marta Soares");
            departamento.AddProfessores("Lidia Carvalho");

            Console.WriteLine(departamento);
        }
    }
}
