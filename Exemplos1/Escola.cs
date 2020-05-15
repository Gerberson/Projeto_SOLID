using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class Escola : IDisposable
    {
        public string Nome { get; set; }
        public List<Departamento> Departamentos { get; set; } = new List<Departamento>();

        public Escola(string nome)
        {
            Nome = nome;
        }

        public void AddDepartamento(string nome)
        {
            Departamentos.Add(new Departamento(this, nome));
        }

        public void Dispose()
        {
            Departamentos.ForEach(x => x.Dispose());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Escola: ");
            sb.AppendLine(Nome);
            sb.Append("Departamentos: ");
            sb.Append(Departamentos.Count);
            sb.AppendLine();
            foreach (var dept in Departamentos)
            {
                sb.AppendLine(dept.Nome);
            }
            return sb.ToString();
        }
    }
}
