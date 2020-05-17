using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.ISP.Violacao.Entitie
{
    class CadastrarCliente : IPersistencia
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Valida Dados");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar Dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Envia E-mail");
        }
    }
}
