using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Periodo
    {
        private int periodos;
        private Disciplina disciplina;

        public Periodo(int periodo) //Construtor recebendo como parâmetro um período e fazendo sua associação
        {
            this.periodos = periodo;
        }
         
        //Construtor recebendo um período e uma disciplica, logo em seguida faz suas associações.
        public Periodo(int periodo, Disciplina disciplina)
        {
            this.periodos = periodo;
            this.disciplina = disciplina;
        }

        //Getters
        public int Periodos { get { return periodos;  } }
        public Disciplina Disciplina { get { return disciplina; } }

        //Verificando se a instância corrente da classe possui (pegando o atributo obj como parâmetro de comparação) uma equivalência entre ambos.
        public override bool Equals(object obj)
        {
            return this.periodos == (obj as Periodo).Periodos && this.disciplina == (obj as Periodo).Disciplina;
        }

        //Método utilizado para comparação entre valores de objetos, diferentemente do método Equals() herdado e não sobrescrito da classe Object 
        //que compara entidades por referência (compara o endereço de memória de dois objetos).
        public override int GetHashCode()
        {
            return this.periodos.GetHashCode() + this.disciplina.GetHashCode();
        }
    }
}
