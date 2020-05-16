using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.OCP.Aderente.Entitie
{
    class Pedido
    {
        public virtual  double DescontoPedido(double valorFinal)
        {
            return valorFinal;
        }
    }
}
