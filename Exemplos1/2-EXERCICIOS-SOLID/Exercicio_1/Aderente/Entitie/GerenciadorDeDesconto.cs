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

            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DescontoMaximoPorFidelidade) ? (decimal) Constantes.DescontoMaximoPorFidelidade / 100 : (decimal)tempoDeContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case EStatusContaCliente.NaoRegistrado:
                    precoAposdesconto = precoProduto;
                    break;
                case EStatusContaCliente.ClienteComum:
                    precoAposdesconto = (precoProduto - (Constantes.DescontoClienteComum * precoProduto));
                    precoAposdesconto = descontoPorFidelidade - (descontoPorFidelidade * precoAposdesconto);
                    break;
                case EStatusContaCliente.ClienteEsprecial:
                    precoAposdesconto = (precoProduto - (Constantes.DescontoClienteEspecial * precoProduto));
                    precoAposdesconto = descontoPorFidelidade - (descontoPorFidelidade * precoAposdesconto);
                    break;
                case EStatusContaCliente.ClienteVIP:
                    precoAposdesconto = (precoProduto - (Constantes.DescontoClienteVIP * precoProduto));
                    precoAposdesconto = descontoPorFidelidade - (descontoPorFidelidade * precoAposdesconto);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return precoAposdesconto;
        }
    }
}
