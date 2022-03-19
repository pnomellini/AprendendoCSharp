using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 Condicionais2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            // Condicional OU
            /*
            if (idadeJoao >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("João possui mais de 18 anos ou está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("João NÃO possui mais de 18 anos ou NÃO está acompanhadO, NÃO pode entrar");
            }
            */

            // Condicional E
            /*
            if (idadeJoao >= 18 && quantidadePessoas >= 2)
            {
                Console.WriteLine("João possui mais de 18 anos ou está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("João NÃO possui mais de 18 anos ou NÃO está acompanhado, NÃO pode entrar");
            }
            */

            // Usando Booleana
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João possui mais de 18 anos ou está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("João NÃO possui mais de 18 anos ou NÃO está acompanhado, NÃO pode entrar");
            }
            Console.WriteLine("Enter");
            Console.ReadLine();

        }


    }
}




