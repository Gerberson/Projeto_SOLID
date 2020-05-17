using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.LSP.Aderente.Entitie
{
    class ContaComum : Conta
    {
        public override void Saque(double valor)
        {
            base.Saque(valor);
        }
    }
}
