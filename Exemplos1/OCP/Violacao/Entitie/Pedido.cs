using Exemplos1.OCP.Violacao.Entitie;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace Exemplos1.OCP.Violado.Entitie
{
    class Pedido
    {
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoCliente.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoCliente.Associado)
            {
                valorFinal = valor - 10;
            }
            else
            {
                valorFinal = valor;
            }
            return valorFinal;
        }
    }
}
