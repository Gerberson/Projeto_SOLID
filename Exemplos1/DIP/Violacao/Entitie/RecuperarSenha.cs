using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.DIP.Violacao.Entitie
{
    class RecuperarSenha
    {
        private MySqlConnection conexaoBanco { get; set; }

        public RecuperarSenha()
        {
            conexaoBanco = new MySqlConnection();
            //CÓDIGO PARA RECUPERAR SENHA
        }
    }
}
