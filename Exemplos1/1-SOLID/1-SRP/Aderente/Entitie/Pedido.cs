using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exemplos1.SRP.Aderente.Entitie
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger _logger { get; set; }
        private EnviarEmail _enviarEmail { get; set; }

        public Pedido()
        {
            _enviarEmail = new EnviarEmail();
            _logger = new RegistraLog();
        }

        public void IncluirPedido()
        {
            try
            {
                _logger.Info("Incluir um pedido");
                _enviarEmail = new EnviarEmail
                {
                    From = "email@gmail.com",
                    To = "email@gmail.com",
                    Subject = "SSP",
                    Body = "Um"
                };

                _enviarEmail.Enviar();
            }
            catch (Exception ex)
            {
                _logger.Info("Erro ao enviar o e-mail: " + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                _logger.Info("Pedido deletado em : " + DateTime.Now);
            }
            catch (Exception ex)
            {
                _logger.Info("Erro ao deletar pedido: " + ex.Message);
            }
        }
    }
}
