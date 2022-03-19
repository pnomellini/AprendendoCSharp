using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int tempo = 3;

            /*valorInvestido = valorInvestido + (valorInvestido * 0.0036);

            Console.WriteLine("Após 1 mês, você terá R$"+valorInvestido);

            valorInvestido = valorInvestido + (valorInvestido * 0.0036);
            */

            for (int i = 1; i <= tempo; i++){

                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + " meses, você terá R$" + valorInvestido);

            };

            
            //Console.WriteLine("Após 2 mês, você terá R$" + valorInvestido);
            Console.WriteLine("Tecle ENTER para sair!");
            Console.ReadLine();
        }
    }
}
