/* Arquivos ".cs" são projetos C# */

// Modulos da linguagem
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Workspace do projeto
namespace HelloWorld{

    // Classe principal do progrma
    internal class Program{

        // Main funçao principal
        static void Main(string[] args){


            // Criando uma variável
            // var teste = "texto";

            // Escrever no console
            Console.WriteLine("Hello World!");

            // Ler algo no console
            Console.ReadLine();

            // Tipos
            // int inteiro;
            // float decima;
            // bool booleano;
            // string texto;
            // char caracter;

            // Dynamic - Não usar
            dynamic test = "text";
            Console.WriteLine(test);
            test = 12;
            Console.WriteLine(test);
            
            // Cosntantes no C#
            // const string hehehe = "copy";
            // const float pi = 3.14f;
        }
    }
}
