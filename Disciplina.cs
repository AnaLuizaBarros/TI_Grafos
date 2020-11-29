using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    public class Disciplina
    {
        private string disciplinas;

        public Disciplina(string disciplina) //Construtor recebendo por parâmetro uma disciplica e atribuindo a variável local.
        {
            this.disciplinas = disciplina;
        }

        public string Disciplinas { get { return disciplinas; } } //Getter da disciplina

        //Verificando se a instância corrente da classe possui (pegando o atributo obj como parâmetro de comparação) uma equivalência entre ambos.
        public override bool Equals(object obj)
        {
            return this.disciplinas == (obj as Disciplina).Disciplinas;
        }

        //Método utilizado para comparação entre valores de objetos, diferentemente do método Equals() herdado e não sobrescrito da classe Object 
        //que compara entidades por referência (compara o endereço de memória de dois objetos).
        public override int GetHashCode()
        {
            return this.disciplinas.GetHashCode();
        }
    }
}
