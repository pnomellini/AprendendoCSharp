using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEoutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            // _double_ é uma variavel de bits (max/min )
            double salario = 1200.50;

            // _Cast_ é mudar o tipo de variavel (ex. Double para int)
            int salarioEmInteiro = (int)salario;

            // _int_ é uma variavel de 32bits (max/min 2.147.483.647)
            int idade = 2147483647;
                        
            // short é uma variavel de 16bits (max/min 32.767)
            short quantidadeProdutos = 32767;

            // long é uma variavel de 64bits (max/min 9.223.372.036.854.775.807)
            long idadeUniveso = 9223372036854775807;

            // float é uma variavel de bits (max/min )
            float altura = 1.80f;

            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Salario em inteiro: " + salarioEmInteiro);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("Quantidade de produtos " + quantidadeProdutos);
            Console.WriteLine("Idade do universo " + idadeUniveso);
            Console.WriteLine("Altura: " + altura);

            Console.WriteLine("Para sair, digite ENTER");
            Console.ReadLine();
        }
    }
}
