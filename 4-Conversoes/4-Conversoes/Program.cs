using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;
            // O int é um tipo de variável que suporta valores ate 32 bits
            int SalarioEmInteiro = (int)salario;
            long idade = 130000000000000;
            Console.WriteLine(idade);
            // O short é um tipo de variavel de 16 bits
            short QuantidadeDeProduto = 15000;
            Console.WriteLine(QuantidadeDeProduto);
            float altura = 1.80f;
            Console.WriteLine(altura);

        }
    }
}
