using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Horario
    {
        //private Aresta aresta;
        private Professor professor;
        private Periodo periodo;
        private Disciplina disciplina;
        private int horarios;

        public Horario(Professor professor) //Construtor recebendo como parâmetro um professor e realizando a associação.
        {
            this.Professor = professor;
        }

        public Horario(Periodo periodo) //Construtor recebendo como parâmetro um periodo e realizando a associação.
        {
            this.Periodo = periodo;
        }

        //Construtor recebendo como parâmetro uma disciplina, um período, um horário e realizando a associação.
        public Horario(Professor professor, Disciplina disciplina, Periodo periodo, int horario)
        {
            this.professor = professor;
            this.periodo = periodo;
            this.disciplina = disciplina;
            this.horarios = horario;
        }

        //Getters e Setters
        public int Horarios { get => horarios; set => horarios = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        //Verificando se a instância corrente da classe possui (pegando o atributo obj como parâmetro de comparação) uma equivalência entre ambos.
        public override bool Equals(object obj)
        {
            return this.professor == (obj as Professor) && this.disciplina.Equals((obj as Professor).Disciplina);
        }
    }
}
