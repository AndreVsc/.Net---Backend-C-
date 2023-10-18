using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07{
    internal class Program{
        static void Main(string[] args){
            // while
            int valor = 0;
            while(valor < 10) {
                Console.WriteLine("Digite um valor");
                valor = int.Parse(Console.ReadLine());
            }

            string[] nomes = {"Pedro", "Thiago", "João", "Paulo", "André" };
            foreach(string n in nomes) {
                
                Console.WriteLine(n);
            
            } // Para cada nome no array, repita o bloco de cógigo
        }
    }
}
