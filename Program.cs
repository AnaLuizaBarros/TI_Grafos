using System;
using System.IO;

namespace TI_Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] leitor = File.ReadAllLines(@"../../../Arquivo.txt");
            Console.WriteLine("\t Alunos: " +
              "\n Ana Luiza Gonçalves Lourenço Barros" +
              "\n Douglas Barbosa da Silva" +
              "\n Jonathan William de Paiva" +
              "\n Lucas Gomes Oliveira" +
              "\n Victor Henrique de Souza Oliveira \n");

            Grafo g = new Grafo();
            foreach (string linha in leitor)
            {
                string[] corte = linha.Split(';');
                Professor professor;
                Disciplina disciplina;
                Periodo periodo;


                professor =  new Professor(corte[1]);
                disciplina = new Disciplina(corte[0]);
                periodo = new Periodo(Convert.ToInt32(corte[2]));
                g.adicionarVerticeProfessor(professor, disciplina);
                g.adicionarVerticePeriodo(periodo);
            }
            g.printarMatriz();
        }
    }
}
