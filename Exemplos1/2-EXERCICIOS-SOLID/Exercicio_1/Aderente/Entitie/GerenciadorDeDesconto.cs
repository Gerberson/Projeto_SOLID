using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class GerenciadorDedescontoPorFidelidadeonto
    {
        public decimal AplicardescontoPorFidelidadeonto(decimal precoProduto, int statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposdesconto = 0;

            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;

            if (statusContaCliente == 1)
            {
                precoAposdesconto = precoProduto;
            }
            else if (statusContaCliente == 2)
            {
                precoAposdesconto = (precoProduto - (0.1m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));
            }
            else if (statusContaCliente == 3)
            {
                precoAposdesconto = (0.7m * precoProduto) - descontoPorFidelidade * (0.7m * precoProduto);
            }
            else if (statusContaCliente == 4)
            {
                precoAposdesconto = (precoProduto - (0.5m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));
            }
            return precoAposdesconto;
        }
    }
}
