using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.SRP.Aderente.Entitie
{
    class RegistraLog : ILogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
