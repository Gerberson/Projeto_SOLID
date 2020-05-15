using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola("Lirios");

            escola.AddDepartamento("Contabilidade");
            escola.AddDepartamento("Recursos Humanos");
            escola.AddDepartamento("Limpeza");

            Console.WriteLine(escola);
        }
    }
}
