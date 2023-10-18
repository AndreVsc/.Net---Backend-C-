using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02{
    internal class Program{
        static void Main(string[] args){

            int numeroInteiro = 5;
            int outroNumeroInteiro = 2;
            int divisao = numeroInteiro/outroNumeroInteiro;
            string palavra = " ";
            Console.WriteLine("Digite uma palavra: ");
            // Ler uma string
            palavra = Console.ReadLine();

            // Divisão de inteiros é uma divisão aredondada para baixo
            Console.WriteLine(divisao);

            // Condição com if e elif

            if (divisao!=2){
                Console.WriteLine("Está Errado!");
            }
            else if(divisao==2){
                Console.WriteLine("Está Certo!");
            }

            Console.ReadLine();
        }
    }
}
