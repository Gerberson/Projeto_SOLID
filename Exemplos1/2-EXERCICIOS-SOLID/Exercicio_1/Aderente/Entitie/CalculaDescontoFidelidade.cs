using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DescontoMaximoPorFidelidade) ? (decimal)Constantes.DescontoMaximoPorFidelidade / 100 : (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFidelidade * preco);
        }
    }
}
