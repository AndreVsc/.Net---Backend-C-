using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05{
    internal class Program{
        static void Main(string[] args){

            int condicao = 2;
            string[] produtos = new string[3] {    // tipo[] nomeArray = new tipo[tamanho] {itens};
                "Pedra",
                "Ferro",
                "Ouro"}; // Array do tipo string

            // Exibir array
            for(int i = 0; i < produtos.Length; i++) {
                Console.WriteLine(produtos[i]);
            }

            // Switch case sem nenhum misterio
            switch (condicao)
            {
                case 0:
                    Console.WriteLine(produtos[condicao]);
                    break;
                ; case 1:
                    Console.WriteLine(produtos[condicao]);
                    break;
                case 2:
                    Console.WriteLine(produtos[condicao]);
                    break;

            }

            Console.ReadLine();
        }
    }
}
