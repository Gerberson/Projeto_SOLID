using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.DIP.Aderente.Entitie
{
    class MySqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com MySql");
        }
    }
}
