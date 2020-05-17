using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1._2_EXERCICIOS_SOLID.Exercicio_1.Aderente.Entitie
{
    interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos); 
    }
}
