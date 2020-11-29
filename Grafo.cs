﻿using System;
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

        public Grafo()
        {

        }


        public void adicionarVerticeProfessor(Professor prof)
        {
            if (professor.Contains(prof))
            {

            }
            else professor.Add(prof);
        }
        public void adicionarVerticePeriodo(Periodo pe, Disciplina disciplina)
        {
            var aux = new Periodo(pe.Periodos, disciplina);
            if (periodo.Contains(aux))
            {

            }
            else periodo.Add(aux);
        }
        public void adicionarAresta(Professor profes, Disciplina disc, Periodo per)
        {
            Aresta aresta = new Aresta(profes, disc, per);
            arestas.Add(aresta);
           /* if(arestas.Where(a => a.Professor.Nome == profes.Nome).Count() > 2 ) {
                arestas.Remove(aresta);
                foreach (var item in arestas)
                {
                    if (arestas.Where(a => a.Professor.Nome == item.Professor.Nome).Count() == 1) {
                        aresta = new Aresta(item.Professor, disc, per);
                        arestas.Add(aresta);
                    }
                }             
            }     */     
        }
        public void VerificarAsrestas() {
            Aresta aresta = new Aresta();                   
            foreach (var item in arestas.ToList())
            {
                if (arestas.Where(a => a.Professor.Nome == item.Professor.Nome).Count() > 2)
                {
                    arestasRemovidas.Add(item);
                    arestas.Remove(item);
                    foreach (var prof in arestas.ToList())
                    {                   
                        if (arestas.Where(a => a.Professor.Nome == prof.Professor.Nome).Count() == 1)
                        {                                                  
                            aresta = new Aresta(prof.Professor, item.Disciplina, item.Periodo);
                            arestas.Add(aresta);
                        }
                    }
                }
            }
         }
            
        
        public void adicionarHorarios()
        {
            VerificarAsrestas();
            arestas.ForEach(lv =>
            {
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
            Console.WriteLine("\n Professores");
            professor.ForEach(lv => Console.WriteLine("Professor: " + lv.Nome ));

            Console.WriteLine("\n Disciplina e Periodo");
            periodo.ForEach(lv => Console.WriteLine("Disciplina: " + lv.Disciplina.Disciplinas + " \t" + "Periodo: " + lv.Periodos));

            Console.WriteLine("\n Arestas");
            arestas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + " \t" + "Periodo: " + lv.Periodo.Periodos));

            Console.WriteLine("\n Horarios");
            Horario.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + "\t" + "Periodo: " + lv.Periodo.Periodos + "\t" + "Horario: " + lv.Horarios));

            Console.WriteLine("\n Arestas removidas");
            arestasRemovidas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + "\t" + "Periodo: " + lv.Periodo.Periodos ));

        }


    }
}
