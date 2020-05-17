using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.DIP.Aderente.Entitie
{
    class RecuperarSenha
    {
        private IDataBaseConnection _conexaoBanco { get; set; }

        public RecuperarSenha(IDataBaseConnection conexaoBanco)
        {
            _conexaoBanco = conexaoBanco;
            //CÓDIGO PARA RECUPERAR SENHA
        }
    }
}
