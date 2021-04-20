using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio retirado de https://www.youtube.com/watch?v=rusnwiGQjQA 

            // Um diretor de uma empresaa quer saber se os seus funcionarios estão gostando da empresa
            //porem caso alguem não goste ele gostaria de saber o motivo.APENAS UM FUNCIONARIO.

            string situacaoFuncionario;
            string resposta;

            Console.WriteLine("Voce está gostando de trabalhar aqui?(S/N)");
            situacaoFuncionario = Console.ReadLine();

            if (situacaoFuncionario.ToUpper() == "S") // toupper e tolower convertem a mensagem para maiusculo ou minusculom respectivamente
            {
                Console.WriteLine("ótimo saber que voce gosta de trabalhar aqui");
            }
            else
            {
                if(situacaoFuncionario.ToLower() == "n")
                {
                    Console.WriteLine("Mas por que voce não gosta de trabalhar aqui ?");
                    resposta = Console.ReadLine();
                    Console.WriteLine("A sua resposta é: " + resposta);
                }
            }

            Console.ReadKey();
        }   
    }
}
