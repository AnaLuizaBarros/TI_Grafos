using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Professor
    {
        private string nome;
        private Disciplina disciplina;


        public Professor(string nome) //Construtor recebendo por parâmetro o nome do professor e fazendo sua associação.
        {
            this.nome = nome;
        }

        public Professor(string nome, Disciplina disciplina) //Construtor recebendo um nome e disciplina de um professor, em seguida fazendo a associação
        {
            this.nome = nome;
            this.disciplina = disciplina;
        }

        //Getters
        public string Nome { get { return nome;  } }
        public Disciplina Disciplina { get { return disciplina; } }

        //Verificando se a instância corrente da classe possui (pegando o atributo obj como parâmetro de comparação) uma equivalência entre ambos.
        public override bool Equals(object obj)
        {
            // return this.nome == (obj as Professor).Nome && this.disciplina.Equals((obj as Professor).Disciplina);
            return this.nome == (obj as Professor).Nome;
        }

        //Método utilizado para comparação entre valores de objetos, diferentemente do método Equals() herdado e não sobrescrito da classe Object 
        //que compara entidades por referência (compara o endereço de memória de dois objetos).
        public override int GetHashCode()
        {
            return this.nome.GetHashCode() + this.disciplina.GetHashCode();
        }
    }
}
