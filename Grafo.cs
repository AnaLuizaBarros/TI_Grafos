using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Grafos
{
    class Grafo
    {
        public List<Aresta> arestas = new List<Aresta>();
        public List<Professor> professor = new List<Professor>();
        public List<Periodo> periodo = new List<Periodo>();

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

        public void adicionarVerticeProfessor(Professor prof, Disciplina disciplina)
        {
            var aux = new Professor(prof.Nome, disciplina);
            if (professor.Contains(aux))
            {

            }
            else professor.Add(aux);
        }
        public void adicionarVerticePeriodo(Periodo pe)
        {
            if (periodo.Contains(pe))
            {

            }
            else periodo.Add(pe);
        }
       public void adicionarAresta(Professor profes, Disciplina disc, Periodo per)
        {
            Aresta aresta = new Aresta(profes, disc, per);
            arestas.Add(aresta);
        }
        /*
        public void adicionarArestaDirigida(Vertice Vert1, Vertice Vert2, int peso, int direcao)
        {
            matadj[Vert1.Vert, Vert2.Vert] = 1;
            matadj[Vert2.Vert, Vert1.Vert] = 1;
            Aresta aresta = new Aresta(Vert1, Vert2, peso, direcao);
            arestas.Add(aresta);


        }*/
        public void printarMatriz()
        {
            /* StringBuilder sb = new StringBuilder();
             sb.AppendLine("\nMatriz de adjacencia ");
             for (int i = 1; i < this.numVertice; i++)
             {
                 for (int j = 1; j < this.numVertice; j++)
                 {
                     sb.Append(" " + matadj[i, j] + " ");
                 }
                 sb.AppendLine("\n ");
             }
             return sb.ToString();*/
            professor.ForEach(lv => Console.WriteLine(lv.Nome + "\t" + lv.Disciplina.Disciplinas));
           // Disciplina.ForEach(lv => Console.WriteLine(lv.Nome + "\t" + lv.Disciplina));
            Console.WriteLine("Periodo");
            periodo.ForEach(lv => Console.WriteLine(lv.Periodos + "\t"));
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
