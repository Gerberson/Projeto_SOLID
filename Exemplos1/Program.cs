using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();
            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe a cor do Quadrado:");
            q.Cor = Console.ReadLine();

            Console.WriteLine("Informe o lado do Quadrado:");
            q.Lado = double.Parse(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine(q.Area);
            Console.WriteLine(q.Perimetro);
            Console.WriteLine(q.Cor);
        }
    }
}
