using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.ISP.Aderente.Entitie
{
    class CadastrarProduto : IPersistencia
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar Dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar Dados");
        }
    }
}
