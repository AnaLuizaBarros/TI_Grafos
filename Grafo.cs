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
        public List<Horario> Horario = new List<Horario>();

        public Grafo()
        {

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
        public void adicionarHorarios()
        {
            arestas.ForEach(lv =>
            {
                var prof = new Horario(lv.Professor);
                var period = new Horario(lv.Periodo);

                if (Horario.Any(p => p.Professor.Nome == lv.Professor.Nome) || Horario.Any(p => p.Periodo == lv.Periodo))
                {
                    if (Horario.Any(p => p.Professor.Nome == lv.Professor.Nome) && Horario.Any(p => p.Periodo == lv.Periodo) && Horario.Any(p => p.Horarios == 1))
                    {
                    }
                    else if ((Horario.Any(p => p.Professor.Nome == lv.Professor.Nome) && Horario.Any(p => p.Periodo == lv.Periodo) && Horario.Any(p => p.Horarios == 2)))
                    {
                    }
                    else if ((Horario.Any(p => p.Professor.Nome == lv.Professor.Nome) && Horario.Any(p => p.Periodo == lv.Periodo) && Horario.Any(p => p.Horarios == 2)))
                    {
                    }
                    else
                    {
                        Horario.Add(new Horario(lv.Professor, lv.Disciplina, lv.Periodo, 2));
                    }

                }
                else Horario.Add(new Horario(lv.Professor, lv.Disciplina, lv.Periodo, 1));
            });

        }
        public void printarMatriz()
        {
            adicionarHorarios();
            Console.WriteLine("\n Professores e disciplinas");
            professor.ForEach(lv => Console.WriteLine("Professor: " + lv.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas));

            Console.WriteLine("\n Periodo");
            periodo.ForEach(lv => Console.WriteLine("Periodo: " + lv.Periodos + "\t"));

            Console.WriteLine("\n Arestas");
            arestas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + " \t" + "Periodo: " + lv.Periodo.Periodos));

            Console.WriteLine("\n Horarios");
            Horario.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + "\t" + "Periodo: " + lv.Periodo.Periodos + "\t" + "Horario: " + lv.Horarios));

        }


    }
}
