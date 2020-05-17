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
                    precoAposdesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(precoProduto);
                    break;
                case EStatusContaCliente.ClienteComum:
                    precoAposdesconto = new ClienteComum().AplicarDescontoStatusConta(precoProduto);
                    precoAposdesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);
                    break;
                case EStatusContaCliente.ClienteEsprecial:
                    precoAposdesconto = new ClienteEspecial().AplicarDescontoStatusConta(precoProduto);
                    precoAposdesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);
                    break;
                case EStatusContaCliente.ClienteVIP:
                    precoAposdesconto = new ClienteVIP().AplicarDescontoStatusConta(precoProduto);
                    precoAposdesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return precoAposdesconto;
        }
    }
}
