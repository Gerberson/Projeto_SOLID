using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class ClienteVIP : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DescontoClienteVIP * preco));
        }
    }
}
