using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Grafos
{
    class Grafos
    {
        public List<Aresta> arestas = new List<Aresta>();
        public List<Vertice> vertices = new List<Vertice>();

        private int[,] matadj;
        public int numVertice;
        private int[] tDescoberta;
        private int[] tTermino;
        private Vertice[] pais;
        private int[] componente;
        private int componentes;
        private bool ciclo;


        public int NumVertice { get; set; }

        public Grafo()
        {

        }

        public Grafo(int NumVertice)
        {
            this.numVertice = NumVertice;

            matadj = new int[numVertice, numVertice];
            tDescoberta = new int[numVertice];
            tTermino = new int[numVertice];
            pais = new Vertice[numVertice];
            componente = new int[numVertice];


            for (int i = 1; i < numVertice; i++)
                for (int j = 1; j < numVertice; j++)
                    matadj[i, j] = 0;

        }

        public void adicionarVertice(Vertice vertice)
        {
            if (vertices.Contains(vertice))
            {

            }
            else vertices.Add(vertice);
        }
        public void adicionarAresta(Vertice Vert1, Vertice Vert2, int peso)
        {
            matadj[Vert1.Vert, Vert2.Vert] = 1;
            matadj[Vert2.Vert, Vert1.Vert] = 1;
            Aresta aresta = new Aresta(Vert1, Vert2, peso);
            arestas.Add(aresta);
        }
        public void adicionarArestaDirigida(Vertice Vert1, Vertice Vert2, int peso, int direcao)
        {
            matadj[Vert1.Vert, Vert2.Vert] = 1;
            matadj[Vert2.Vert, Vert1.Vert] = 1;
            Aresta aresta = new Aresta(Vert1, Vert2, peso, direcao);
            arestas.Add(aresta);


        }
        public string printarMatriz()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nMatriz de adjacencia ");
            for (int i = 1; i < this.numVertice; i++)
            {
                for (int j = 1; j < this.numVertice; j++)
                {
                    sb.Append(" " + matadj[i, j] + " ");
                }
                sb.AppendLine("\n ");
            }
            return sb.ToString();
        }

        public List<Aresta> GetArestas()
        {
            return this.arestas;
        }
        public bool isAdjacente(Vertice Vert1, Vertice Vert2)
        {
            for (int i = 1; i < numVertice; i++)
            {
                for (int j = 1; j < numVertice; j++)
                {
                    if (matadj[Vert1.Vert, Vert2.Vert] == 1)
                    {
                        Console.WriteLine("Os vertices {0} e {1} sao adjacentes", Vert1.Vert, Vert2.Vert);
                        return true;
                    }
                }

            }
            return false;
        }


        public List<Vertice> adjacentes(Vertice vertice)
        {
            List<Vertice> adjacentes = new List<Vertice>();

            for (int j = 1; j < numVertice; j++)
            {
                if (matadj[vertice.Vert, j] > 0)
                {
                    adjacentes.Add(new Vertice(j));

                }
            }

            return adjacentes;
        }

        public int getGrau(Vertice vertice)
        {
            int grau = 0;

            for (int j = 1; j < this.numVertice; j++)
            {

                if (matadj[vertice.Vert, j] == 1)
                {
                    grau++;

                }
            }
            return grau;
        }

    }
}
