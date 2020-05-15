using System;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviarEmail(destino: "destino@gmail.com", assunto: "Teste", titulo: "Urgente");
            EnviarEmail(titulo: "Urgente", assunto: "Teste", destino: "destino@gmail.com");
            EnviarEmail(assunto: "Teste", destino: "destino@gmail.com", titulo: "Urgente");
        }

        //PARAMENTRO NOMEADOS VOCÊ NÃO PRECISA RESPEITAR A ORDEM EM QUE OS PARAMETROS FOI DEFINIDO
        static void EnviarEmail(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"{destino} - {titulo} - {assunto}");
        }
    }
}
