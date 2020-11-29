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
         
        public Grafo() //Construtor padrão
        {

        }

        //Método responsável por receber por parâmetro um professor e fazer sua adição na lista de Professores.
        public void adicionarVerticeProfessor(Professor prof)
        {
            //Se a lista Professor não conter o professor que está sendo passado por parâmetro, ela será adicionado, caso o retorno seja false, nada será feito.
            if (!professor.Contains(prof))
                    professor.Add(prof);
        }

        //Método que recebe por parâmetro um período e sua respectiva disciplina a fim de inserir na lista de periodos.
        public void adicionarVerticePeriodo(Periodo pe, Disciplina disciplina)
        {
            //variável contendo a informação da instanciação Periodo.
            var aux = new Periodo(pe.Periodos, disciplina);

            //Se a lista Periodo não conter o periodo e a disciplina que estão na variável auxiliar, será retornado true e será feito a adição. Caso o retorno seja false, nada ocorrerá.
            if (!periodo.Contains(aux))
                periodo.Add(aux);
        }

        //Método que recebe por parâmetro professor, sua respectiva disciplina e período, para se insetir na lista de arestas.
        public void adicionarAresta(Professor profes, Disciplina disc, Periodo per)
        {
            //Fazendo a instanciação e a inserção na lista de Arestas.
            Aresta aresta = new Aresta(profes, disc, per);
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

            //Percorre a lista de arestas
            foreach (var item in arestas.ToList())
            {
                //Se existem professores com mais de duas disciplinas na arestas, ele será removido e será adixionado na lista de arestasRemovidas.
                if (arestas.Where(a => a.Professor.Nome == item.Professor.Nome).Count() > 2)
                {
                    arestasRemovidas.Add(item);
                    arestas.Remove(item);

                    //Percorre todos os elementos contidos na lista de professor
                    foreach (var prof in professor.ToList())
                    {

                        //Verifica na lista de professores se existe um professor que tenha o grau um, se sim, ele adiciona na lista de arestas
                        if (arestas.Where(a => a.Professor.Nome == prof.Nome).Count() == 1)
                        {
                            aresta = new Aresta(prof, item.Disciplina, item.Periodo);
                            arestas.Add(aresta);
                            break;
                        }
                        //Se não, não será executado nada.
                    }
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
        }

        //Método responsável pela impressão de forma organizada dos elementos contidos em todas as listas criadas.
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
