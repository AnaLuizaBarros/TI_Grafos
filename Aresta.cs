using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Aresta
    { 

        private Professor professor;
        private Periodo periodo;
        private Disciplina disciplina;

        public Aresta() { 
        }
        public Aresta(Professor professor, Disciplina disciplina, Periodo periodo )
        {
            this.Professor = professor;
            this.Periodo = periodo;
            this.Disciplina = disciplina;
        }

        public Professor Professor { get => professor; set => professor = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }
    }
}
