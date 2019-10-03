using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            char PrimeiraLetra = ' ';
            Console.WriteLine(PrimeiraLetra);
            PrimeiraLetra = (char)61;
            Console.WriteLine(PrimeiraLetra);
            PrimeiraLetra = (char)(PrimeiraLetra + 1);
            Console.WriteLine(PrimeiraLetra);
            string titulo = "Alura cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);
            string cursosProgramacao = @"- .NET
 - Java
 - Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
