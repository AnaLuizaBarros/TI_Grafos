using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Vertice
    {
        private int vert;
        private int grau;

        public Vertice() { } //Construtor padrão

        public Vertice(int vert, int grau) //Construtor recebendo dois parâmetros (Vertices e Arestas) e fazendo sua associação
        {
            this.vert = vert;
            this.grau = grau;
        }
        public Vertice(int vert) //Construtor recebendo somente o vértice e fazendo associação
        {
            this.vert = vert;
        }

        //Getters
        public int Grau { get { return this.grau; } }
        public int Vert { get { return this.vert; } }

        //Verificando se a instância corrente da classe possui (pegando o atributo obj como parâmetro de comparação) uma equivalência entre ambos.
        public override bool Equals(object obj)
        {
            if ((obj as Vertice).Vert == this.vert && (obj as Vertice).Grau == this.grau) return true;
            else return false;
        }

        //Método utilizado para comparação entre valores de objetos, diferentemente do método Equals() herdado e não sobrescrito da classe Object 
        //que compara entidades por referência (compara o endereço de memória de dois objetos).
        public override int GetHashCode()
        {
            return HashCode.Combine(vert, grau);
        }
    }
}
