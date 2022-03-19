using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos, pode entrar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João é menor mas está acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("João NÃO possui mais de 18anos, não pode entrar");
                }

            }

            Console.WriteLine("Enter");
            Console.ReadLine();
        }
    }
}
