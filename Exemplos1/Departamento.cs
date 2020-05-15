using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos1
{
    class Departamento : IDisposable
    {
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; } = new List<Professor>();

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public void AddProfessores(string nome)
        {
            Professores.Add(new Professor(nome));
        }

        public void Dispose()
        {
            //DESTROI O DEPARTAMENTO
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Departamentos: ");
            sb.AppendLine(Nome);
            sb.Append("Professores: ");
            sb.Append(Professores.Count);
            sb.AppendLine();
            foreach (var prof in Professores)
            {
                sb.AppendLine(prof.Nome);
            }
            return sb.ToString();
        }
    }
}
