using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class GerenciadorDedesconto
    {
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _descontoStatusConta;
        public GerenciadorDedesconto(ICalculaDescontoFidelidade calculaDescontoFidelidade, ICalculaDescontoStatusContaFactory descontoStatusConta)
        {
            _descontoStatusConta = descontoStatusConta;
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
        }
        public decimal AplicardescontoPorFidelidadeonto(decimal precoProduto, EStatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposdesconto = 0;

            precoAposdesconto = _descontoStatusConta
                .GetCalculaDescontoStatusConta(statusContaCliente)
                .AplicarDescontoStatusConta(precoProduto);
            precoAposdesconto = _calculaDescontoFidelidade
                .AplicarDescontoFidelidade(precoAposdesconto, tempoDeContaEmAnos);

            return precoAposdesconto;
        }
    }
}
