using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class GerenciadorDedesconto
    {
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;
        public GerenciadorDedesconto(ICalculaDescontoFidelidade calculaDescontoFidelidade)
        {
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
        }
        public decimal AplicardescontoPorFidelidadeonto(decimal precoProduto, EStatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposdesconto = 0;

            switch (statusContaCliente)
            {
                case EStatusContaCliente.NaoRegistrado:
                    precoAposdesconto = precoProduto;
                    break;
                case EStatusContaCliente.ClienteComum:
                    precoAposdesconto = (precoProduto - (Constantes.DescontoClienteComum * precoProduto));
                    precoAposdesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);
                    break;
                case EStatusContaCliente.ClienteEsprecial:
                    precoAposdesconto = (precoProduto - (Constantes.DescontoClienteEspecial * precoProduto));
                    precoAposdesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);
                    break;
                case EStatusContaCliente.ClienteVIP:
                    precoAposdesconto = (precoProduto - (Constantes.DescontoClienteVIP * precoProduto));
                    precoAposdesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return precoAposdesconto;
        }
    }
}
