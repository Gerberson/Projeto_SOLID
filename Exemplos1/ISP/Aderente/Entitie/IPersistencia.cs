using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1.ISP.Aderente.Entitie
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();
    }
}
