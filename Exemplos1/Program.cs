using Exemplos1.LSP.Aderente.Entitie;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Transactions;

namespace Exemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USANDO A CLASSE CONTACOMUM");
            Conta conta = new ContaComum();
            conta.Saldo = 100;
            conta.Saque(250);
            Console.WriteLine($"Saldo de conta : {conta.Saldo}");
            Console.WriteLine();

            Console.WriteLine("USANDO A CLASSE CONTAPOUPANÇA");
            Conta conta1 = new ContaPoupanca();
            conta1.Saldo = 100;
            conta1.Saque(250);
            Console.WriteLine($"Saldo de conta : {conta1.Saldo}");
        }
    }
}
