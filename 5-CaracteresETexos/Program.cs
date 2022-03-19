using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto 5 - Caracteres e Texto");

            // caracter
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //ver ASCII TABLE para saber sobre qual numero representa um caractere

            string titulo = "Alura cursos de tecnologia";
            string cursos = @"-.NET
- JAVA
- JAVA SCRIPT";

            Console.WriteLine(titulo);
            Console.WriteLine(cursos);

            Console.WriteLine("TECLE ENTER PARA FECHAR");
            Console.ReadLine();
        }
    }
}
