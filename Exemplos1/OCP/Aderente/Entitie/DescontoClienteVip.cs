using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.OCP.Aderente.Entitie
{
    class DescontoClienteVip : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 100;
        }
    }
}
