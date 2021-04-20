using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1 - Write_Read_e_variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercico Retirado de https://www.youtube.com/watch?v=JYYmmKEAv0w

            string Condicao; //variavel Condicao criada
            Console.WriteLine("Hello World"); // writeline pula a linha automaticamente diferentemente do write
            Console.WriteLine("How are you?");
            Condicao = Console.ReadLine(); // Condicao será igual ao q for digitado no teclado pelo comando readline (leia)
            Console.WriteLine("Your condition is " + Condicao); //o texto está sendo concatenado com a variavel Condicao


            Console.ReadKey();// na hora de abrir o prompt não fecha automaticamente , espera que uma tecla seja apertada
        }
    }
}
