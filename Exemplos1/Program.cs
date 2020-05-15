using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Exemplo("Teste da palavra THIS"));
        }
    }

    class Teste
    {
        public string Nome { get; set; }

        public Teste(Exemplo exemplo)
        {
            Nome = exemplo.Fornecedor;
        }
    }

    class Exemplo
    {
        public string Fornecedor { get; set; }

        public Exemplo(string nome)
        {
            Fornecedor = nome;

            Teste teste = new Teste(this);

            Console.WriteLine(teste.Nome);
        }
    }
}
