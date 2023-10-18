using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Criar um tipo com ENUM

namespace Aula_06 {
    internal class Program{
                  //   0     1       2       3
        enum Color { Blue , Green , Red , Vermelho}
        enum Opcoes { Play=1 ,Delete, Edit, List , Refresh}

        static void Main(string[] args){
            Color colorFavorite = Color.Blue;
            Color colorFavorite2 = Color.Green;

            Console.WriteLine(colorFavorite);
            Console.WriteLine(colorFavorite2);
            Console.WriteLine((Color)3);  // Vermelho

            Menu();

            Console.ReadLine();
        
        }

        static void Menu(){
            Console.WriteLine("-------------------------");
            Console.WriteLine("      Seja Bem-Vindo     ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("     Escolha alguma das  ");
            Console.WriteLine("      Opçôes a baixo :   ");
            Console.WriteLine("                         ");
            Console.WriteLine("    1.     Jogar         ");
            Console.WriteLine("    2.     Delete        ");
            Console.WriteLine("    3.      Edit         ");
            Console.WriteLine("    4.      List         ");
            Console.WriteLine("    5.     Refresh       ");
            Console.WriteLine("                         ");
            Console.WriteLine("   Escolha:              ");
            Console.WriteLine("-------------------------");
            int num = int.Parse(Console.ReadLine());
            Opcoes opcaoSelecionada = (Opcoes)num;
            Console.WriteLine("\n");
            switch (opcaoSelecionada) { 
                case Opcoes.Play:
                    Console.WriteLine("Iniciando partida...");
                    break;
                case Opcoes.Delete:
                    Console.WriteLine("Personagem deletado.");
                    break;
                case Opcoes.Edit:
                    Console.WriteLine("Entrando em modo de edição...");
                    break;
                case Opcoes.List:
                    Console.WriteLine("Listando personagens : ...");
                    break;
                case Opcoes.Refresh:
                    Console.WriteLine("Atualizando a pagina");
                    break;
                default:
                    Console.WriteLine("Aconteceu algo de errado! ");
                    break;
            }

        }
    }
}
