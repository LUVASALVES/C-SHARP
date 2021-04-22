using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {     // Exercicio disponível https://www.youtube.com/watch?v=E2dT-41FntU
            //Exercício 01: Desenvolva um algoritmo que solicite a 
            //entrada de um número e calcule se onúmero é par ou impar.

            int n;
            Console.Write("Digite um numero : ");
            n = Convert.ToInt32(Console.ReadLine());           
            

            if (n % 2 == 0)
            {
                Console.WriteLine("O número " + n +" é par");
            }
            if(n != 0)
            {
                Console.WriteLine("O número " + n +" é impar");
            }


            Console.ReadKey();
        }   
    }
}
