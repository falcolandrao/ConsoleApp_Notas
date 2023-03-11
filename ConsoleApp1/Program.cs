using System;

namespace ConsoleApp1
{
    class Program
    {



        static string calculaMediaAritmetica(string notaValor01, string notaValor02)

        {

            const int valorPonderado = 7; int mediaAritmetica = 0;



            mediaAritmetica = (int.Parse(notaValor01) + int.Parse(notaValor02) / int.Parse("2"));



            var resultadoFinal = (mediaAritmetica >= valorPonderado) ? "Aprovado" : "Reprovado";



            return resultadoFinal;

        }



        static void Main(string[] args)
        {

            Console.WriteLine(" ### Programa Média Aritmética  ### ");

            string n1 = "8";

            string n2 = "9";

            string msgValida = calculaMediaAritmetica(n1, n2);



            Console.WriteLine("Média Final >> " + msgValida);

            Console.ReadKey();

        }

    }

}
