using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    class CalculaDescontaStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(EStatusContaCliente statusContaClientes)
        {
            ICalculaDescontoStatusConta calcular;
            switch (statusContaClientes)
            {
                case EStatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;
                case EStatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;
                case EStatusContaCliente.ClienteEsprecial:
                    calcular = new ClienteEspecial();
                    break;
                case EStatusContaCliente.ClienteVIP:
                    calcular = new ClienteVIP();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return calcular;
        }
    }
}
