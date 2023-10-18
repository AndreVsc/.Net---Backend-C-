using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04{

    public class Produtos {
        public string Nome { get; set; }
        public int Valor { get; set; }
    }

    internal class Program{
        static void Main(string[] args) {

            //Criando um Objeto em C#
            Produtos produto = new Produtos();

            produto.Nome = "Curso de C#";
            produto.Valor = 100;

            GeradorProduto(produto);

            // Chamando a função
            Teste();

            // Testando estrutura de repetição
            for(int i = 1; i <= 10; i++){
                Contador(i);
            }

            Console.ReadLine();
        }

        // Criando uma função - static = function
        static void Teste(){
            Console.WriteLine("Testando...");
        }

        static void Contador(int i){
            Console.WriteLine("-  "+i);
        }

        // Ultilizando Objeto em função
        static void GeradorProduto(Produtos produto){
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Valor);
        }
    }

}
