using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Horario
    {
        private Aresta aresta;
        private Professor professor;
        private Periodo periodo;
        private Disciplina disciplina;
        private int horarios;

        public Horario(Professor professor)
        {
            this.Professor = professor;

        }

        public Horario(Periodo periodo)
        {

            this.Periodo = periodo;

        }

        public Horario(Professor professor, Disciplina disciplina, Periodo periodo, int horario)
        {
            this.professor = professor;
            this.periodo = periodo;
            this.disciplina = disciplina;
            this.horarios = horario;
        }

        public int Horarios { get => horarios; set => horarios = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        public override bool Equals(object obj)
        {
            return this.professor == (obj as Professor) && this.disciplina.Equals((obj as Professor).Disciplina);
        }
    }
}
