using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula16, Calcule a media ponderada, tipo double
            //Jonas Valereo  - Técnico em Informática

            //Declarando as variaveis tipo double

            double nota1, nota2, nota3, peso1, peso2, peso3, soma, media;

            //Declarando a variaveis peso1, peso2, peso3

            peso1 = 2;
            peso2 = 3;
            peso3 = 5;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a 1 nota: ");
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2 nota: ");
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 3 nota: ");
            nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Declarando a variavel soma dos pesos 1 , 2 , 3;

            soma = peso1 + peso2 + peso3;

            //Declarando a variavel media ponderada 

            media = (peso1 * nota1 + peso2 * nota2 + peso3 * nota3) / soma;


            //imprimir saida de dados no console, método WhriteLine, concatenação
         
            Console.WriteLine("A media pondera: " + media.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Teste de novo!!!");
           

            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada


            Console.ReadKey();

            //Fim do programa 



        }
    }
}
