using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Professor
    {
        private string nome;
        private Disciplina disciplina;


        public Professor(string nome)
        {
            this.nome = nome;
        }

        public Professor(string nome, Disciplina disciplina)
        {
            this.nome = nome;
            this.disciplina = disciplina;
        }

        public string Nome { get { return nome;  } }
        internal Disciplina Disciplina { get { return disciplina; } }
    }
}
