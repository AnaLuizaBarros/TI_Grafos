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
<<<<<<< HEAD
         
        public Grafo() //Construtor padrão
        {

        }

        //Método responsável por receber por parâmetro um professor e fazer sua adição na lista de Professores.
        public void adicionarVerticeProfessor(Professor prof)
        {
            //Se a lista Professor não conter o professor que está sendo passado por parâmetro, ela será adicionado, caso o retorno seja false, nada será feito.
            if (!professor.Contains(prof))
                    professor.Add(prof);
=======

        public void adicionarVerticeProfessor(Professor prof)
        {
            if (!professor.Contains(prof))
                professor.Add(prof);
>>>>>>> 661af4459d731dc411c0e7942000336ddb6dd5b5
        }

        //Método que recebe por parâmetro um período e sua respectiva disciplina a fim de inserir na lista de periodos.
        public void adicionarVerticePeriodo(Periodo pe, Disciplina disciplina)
        {
            //variável contendo a informação da instanciação Periodo.
            var aux = new Periodo(pe.Periodos, disciplina);
<<<<<<< HEAD

            //Se a lista Periodo não conter o periodo e a disciplina que estão na variável auxiliar, será retornado true e será feito a adição. Caso o retorno seja false, nada ocorrerá.
=======
>>>>>>> 661af4459d731dc411c0e7942000336ddb6dd5b5
            if (!periodo.Contains(aux))
                periodo.Add(aux);
        }

        //Método que recebe por parâmetro professor, sua respectiva disciplina e período, para se insetir na lista de arestas.
        public void adicionarAresta(Professor profes, Disciplina disc, Periodo per)
        {
            //Fazendo a instanciação e a inserção na lista de Arestas.
            Aresta aresta = new Aresta(profes, disc, per);
<<<<<<< HEAD
            arestas.Add(aresta);     
        }

        //Método responsável por realizar a verificação em caso de conflito de duas ou mais ocorrencias de um professor ministrando aulas no mesmo período.
        public void VerificarArestas() 
        {
            Aresta aresta = new Aresta();
            foreach (var item in arestas.ToList()) //Percorrendo cada elemento presente na lisya Aresta
            {
                //Se ocorrer de um professor ministrar mais de duas matérias no mesmo período, ele será retirado da lista de Arestas 
                //e colocado em outra lista denominada arestasRemovidas, para ser mostrado ao final do processo o conflito.
                if (arestas.Where(a => a.Periodo.Periodos == item.Periodo.Periodos).Count() > 2)
                {
                    arestasRemovidas.Add(item);
                    arestas.Remove(item);
                }
            }
            //Realizando a ordenção por período
            arestasRemovidas = arestasRemovidas.OrderBy(a => a.Periodo.Periodos).ToList();
        }
       
        //Método responsável por adicionar na lista de Horário os períodos já contidos através da recuperação do método VerificarArestas.
        public void adicionarHorarios()
        {
            VerificarArestas(); //Invocando a chamada do método

            //Percorrendo a lista de Arestas
            arestas.ForEach(lv =>
            {
                //Se não tiver nenhum horário que possua o periodo, adiciona o professor, a disciplina e o periodo no primeiro horario.
                if (!Horario.Any(p => p.Periodo.Periodos == lv.Periodo.Periodos))
                    Horario.Add(new Horario(lv.Professor, lv.Disciplina, lv.Periodo, 1));

                //Se não, verifica se o horario é 1 ou diferente de 2, (irrelevante) e adiciona no horario 2. 
                else if (Horario.First(p => p.Periodo.Periodos == lv.Periodo.Periodos).Horarios != 2)
                    Horario.Add(new Horario(lv.Professor, lv.Disciplina, lv.Periodo, 2));

                //Se nao cair em nenhuma condicional, nada é feito.
            });
            Horario = Horario.OrderBy(h => h.Periodo.Periodos).ToList(); //Realizando a ordenação por período na lista Horario
=======
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
>>>>>>> 661af4459d731dc411c0e7942000336ddb6dd5b5
        }

        //Método responsável pela impressão de forma organizada dos elementos contidos em todas as listas criadas.
        public void printarMatriz()
        {
            adicionarHorarios();
            int maxDisciplinas = arestas.Max(p => p.Disciplina.Disciplinas.Length);
            int maxProfessor = arestas.Max(p => p.Professor.Nome.Length);
            int maxPeriodos = arestas.Max(p => p.Periodo.Periodos.ToString().Length);
            Console.WriteLine("\n Professores");
            professor.ForEach(lv => Console.WriteLine("Professor: " + lv.Nome ));

            Console.WriteLine("\n Disciplina e Periodo");
            periodo.ForEach(lv => Console.WriteLine("Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + " \t" + "Periodo: " + lv.Periodos));

            Console.WriteLine("\n Arestas");
            arestas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + adicionarEspaco(lv.Professor.Nome, maxProfessor) + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + " \t" + "Periodo: " + lv.Periodo.Periodos));
 
            Console.WriteLine("\n Horarios");
            Horario.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + adicionarEspaco(lv.Professor.Nome, maxProfessor) + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + "\t" + "Periodo: " + lv.Periodo.Periodos + adicionarEspaco(lv.Periodo.Periodos.ToString(), maxPeriodos) + "\t" + "Horario: " + lv.Horarios));

            Console.WriteLine("\n Arestas removidas");
<<<<<<< HEAD
            arestasRemovidas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + adicionarEspaco(lv.Professor.Nome, maxProfessor) + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + adicionarEspaco(lv.Disciplina.Disciplinas, maxDisciplinas) + "\t" + "Periodo: " + lv.Periodo.Periodos ));
            

=======
            arestasRemovidas.ForEach(lv => Console.WriteLine("Professor: " + lv.Professor.Nome + "\t" + "Disciplina: " + lv.Disciplina.Disciplinas + "\t" + "Periodo: " + lv.Periodo.Periodos ));
>>>>>>> ac4ad89b8261d07718647610559d717d7dc1d0cc
        }

        private string adicionarEspaco(string nome, int max)
        {
            return nome.Length < max ? new String(' ', max - nome.Length) : "";
        }
    }
}
