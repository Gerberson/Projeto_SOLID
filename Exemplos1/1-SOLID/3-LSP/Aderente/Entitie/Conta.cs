using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Exemplos1.LSP.Aderente.Entitie
{
    abstract class Conta
    {
        public double Saldo { get; set; }

        public virtual void Saque(double valor)
        {
            Saldo -= valor;
        }
    }
}
