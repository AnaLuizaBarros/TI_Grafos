using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    public class Disciplina
    {
        private string disciplinas;

        public Disciplina(string disciplina)
        {
            this.disciplinas = disciplina;
        }

        public string Disciplinas { get { return disciplinas; } }

        public override bool Equals(object obj)
        {
            return this.disciplinas == (obj as Disciplina).Disciplinas;
        }

        public override int GetHashCode()
        {
            return this.disciplinas.GetHashCode();
        }
    }
}
