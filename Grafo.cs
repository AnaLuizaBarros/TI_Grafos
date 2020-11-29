using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Grafos
{
    class Grafo
    {
        public List<Aresta> arestas = new List<Aresta>();
        public List<Aresta> arestasRemovidas = new List<Aresta>();
        public List<Professor> professor = new List<Professor>();
        public List<Periodo> periodo = new List<Periodo>();
        public List<Horario> Horario = new List<Horario>();

        public void adicionarVerticeProfessor(Professor prof)
        {
            if (!professor.Contains(prof))
                professor.Add(prof);
        }
        public void adicionarVerticePeriodo(Periodo pe, Disciplina disciplina)
        {
            var aux = new Periodo(pe.Periodos, disciplina);
            if (!periodo.Contains(aux))
                periodo.Add(aux);
        }
        public void adicionarAresta(Professor profes, Disciplina disc, Periodo per)
        {
            Aresta aresta = new Aresta(profes, disc, per);
            arestas.Add(aresta);
        }
        public void VerificarArestas() {
            Aresta aresta = new Aresta();
            foreach (var item in arestas.ToList())
            {
                if (arestas.Where(a => a.Periodo.Periodos == item.Periodo.Periodos).Count() > 2)
                {
                    arestasRemovidas.Add(item);
                    arestas.Remove(item);
                }
            }           
       
            foreach (var item in arestas.ToList())
            {                        
                if (arestas.Where(a => a.Professor.Nome == item.Professor.Nome).Count() > 2)
                {
                    arestasRemovidas.Add(item);
                    arestas.Remove(item);
                    foreach (var prof in professor.ToList())
                    {
                        if (arestas.Where(a => a.Professor.Nome == prof.Nome).Count() == 1)
                        {
                            aresta = new Aresta(prof, item.Disciplina, item.Periodo);
                            arestas.Add(aresta);
                            break;                          
                        }
                    }
                }               
            }
            arestasRemovidas = arestasRemovidas.OrderBy(a => a.Periodo.Periodos).ToList();
        }                
        public void adicionarHorarios()
        {
            VerificarArestas();
            arestas.ForEach(lv =>
            {
                if (!Horario.Any(p => p.Periodo.Periodos == lv.Periodo.Periodos))
                    Horario.Add(new Horario(lv.Professor, lv.Disciplina, lv.Periodo, 1));
                else if(Horario.First(p => p.Periodo.Periodos == lv.Periodo.Periodos).Horarios != 2)
                    Horario.Add(new Horario(lv.Professor, lv.Disciplina, lv.Periodo, 2));
            });
            Horario =  Horario.OrderBy(h => h.Periodo.Periodos).ToList();
        }
        public void printarMatriz()
        {
            adicionarHorarios();
            int maxDisciplinas = arestas.Max(p => p.Disciplina.Disciplinas.Length);
            int maxProfessor = arestas.Max(p => p.Professor.Nome.Length);
            int maxPeriodos = arestas.Max(p => p.Periodo.Periodos.ToString().Length);
            Console.WriteLine("\n Professores");
            professor.ForEach(lv => Console.WriteLine("Professor: " + lv.Nome));

            Console.WriteLine("\n Disciplina e Periodo");
            periodo.ForEach(lv => Console.WriteLine("Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + " \t" + "Periodo: " + lv.Periodos));

            Console.WriteLine("\n Arestas");
            arestas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + adicionarEspaco(lv.Professor.Nome, maxProfessor) + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + " \t" + "Periodo: " + lv.Periodo.Periodos));

            Console.WriteLine("\n Horarios");
            Horario.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + adicionarEspaco(lv.Professor.Nome, maxProfessor) + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + "\t" + "Periodo: " + lv.Periodo.Periodos + adicionarEspaco(lv.Periodo.Periodos.ToString(), maxPeriodos) + "\t" + "Horario: " + lv.Horarios));

            Console.WriteLine("\n Arestas removidas");
            arestasRemovidas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + adicionarEspaco(lv.Professor.Nome, maxProfessor) + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + "\t" + "Periodo: " + lv.Periodo.Periodos));
        }

        private string adicionarEspaco(string nome, int max)
        {
            return nome.Length < max ? new String(' ', max - nome.Length) : "";
        }
    }
}
