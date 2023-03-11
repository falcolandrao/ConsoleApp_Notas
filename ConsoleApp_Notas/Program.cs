using System;

namespace ConsoleApp_Notas
{
    class Program
    {

        static string calculaMediaAritmetica(int notaValor01, int notaValor02)
        {
            const int valorPonderado = 7; int mediaAritmetica = 0;

            mediaAritmetica = (notaValor01 + notaValor02) / 2;

            var resultadoFinal = (mediaAritmetica >= valorPonderado) ? "Aprovado" : "Reprovado";

            return resultadoFinal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" ### Programa Média Aritmética  ### ");

            string msgValida = calculaMediaAritmetica(8, 9).ToString();

            Console.WriteLine("Média Final >> " + msgValida);
            Console.ReadKey();
        }
    }
}
