using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX___3_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //vídeo para o exercicio https://www.youtube.com/watch?v=JU_n-NPgk-o

            //uma escola te contratou para desenvolver um aplicativo que realize a média
            // das notas dos alunos de uma sala, lembrando que atualmente a sala tem apenas
            //5 alunos e a nota vai de 0 a 10.

            Console.WriteLine("Média de alunos");

            float soma = 0; //variaveis do tipo float iniciadas
            float media = 0;

            for(int i = 1 ;i<=5 ;i++) // for(int i = 0 ;i<5 ;i++ ) é o exemplo de estrutura de loop.
            {
                Console.WriteLine("Digite a nota do aluno " + i + ": ");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota); // tryparse tenta converter a string que será digitada pelo readline em float e em seguida devolve para a variavel nota
                soma += nota; // soma vai ir complementando a cada nota recebida
                Console.WriteLine(i + "contador" + soma); //criado apenas para ver o andamento das variaveis
            }

            media = soma / 5;
            Console.WriteLine("Média é igual a: " + media);
            Console.ReadKey();
        }
    }
}
