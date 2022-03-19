using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensgemAdicional;

            if (acompanhado == true)
            {
                mensgemAdicional = "João está acompanhado";
            }
            else
            {
                mensgemAdicional = "João NÃO está acompanhado";
            }

            // Usando &&
            /*
            if (idadeJoao >= 18 && acompanhado == true)
            */

            // Usando ||
            if (idadeJoao >= 18 || acompanhado == true) 
            {
                Console.WriteLine("João pode entrar!");
                Console.WriteLine(mensgemAdicional);
            }
            else
            {
                Console.WriteLine("João NÃO pode entrar");
               
            }
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
    }
}
