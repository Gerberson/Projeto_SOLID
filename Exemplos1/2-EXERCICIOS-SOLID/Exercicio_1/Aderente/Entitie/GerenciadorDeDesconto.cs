using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class GerenciadorDedescontoPorFidelidadeonto
    {
        public decimal AplicardescontoPorFidelidadeonto(decimal precoProduto, EStatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposdesconto = 0;

            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case EStatusContaCliente.NaoRegistrado:
                    precoAposdesconto = precoProduto;
                    break;
                case EStatusContaCliente.ClienteComum:
                    precoAposdesconto = (precoProduto - (0.1m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));
                    break;
                case EStatusContaCliente.ClienteEsprecial:
                    precoAposdesconto = (0.7m * precoProduto) - descontoPorFidelidade * (0.7m * precoProduto);
                    break;
                case EStatusContaCliente.ClienteVIP:
                    precoAposdesconto = (precoProduto - (0.5m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));
                    break;
                default:
                    throw new NotImplementedException();
            }

            return precoAposdesconto;
        }
    }
}
