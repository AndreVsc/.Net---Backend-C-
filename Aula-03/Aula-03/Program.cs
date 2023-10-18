using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (idade > 11 && idade < 18)
            {
                Console.WriteLine("Você é um adcolescente!");
            }
            else if (idade >= 18 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto!");
            }
            else{
                Console.WriteLine("Você é idoso!");
            }

            Console.ReadLine();
        }
    }
}
