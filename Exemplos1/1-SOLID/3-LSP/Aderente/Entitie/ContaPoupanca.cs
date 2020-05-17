using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.LSP.Aderente.Entitie
{
    class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            if (Saldo >  valor)
            {
                Saldo -= valor;
            }
        }
    }
}
