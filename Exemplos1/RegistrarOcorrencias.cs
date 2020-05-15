using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class RegistrarOcorrencias
    {
        private readonly IRegistro _registro;

        public RegistrarOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
