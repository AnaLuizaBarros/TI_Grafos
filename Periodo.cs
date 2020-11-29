using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Periodo
    {
        private int periodos;
        private Disciplina disciplina;


        public Periodo(int periodo)
        {
            this.periodos = periodo;
        }
        public Periodo(int periodo, Disciplina disciplina)
        {
            this.periodos = periodo;
            this.disciplina = disciplina;
        }

        public int Periodos { get { return periodos;  } }
        internal Disciplina Disciplina { get { return disciplina; } }

        public override bool Equals(object obj)
        {
            return this.periodos == (obj as Periodo).Periodos && this.disciplina == (obj as Periodo).Disciplina;
        }

        public override int GetHashCode()
        {
            return this.periodos.GetHashCode() + this.disciplina.GetHashCode();
        }
    }
}
