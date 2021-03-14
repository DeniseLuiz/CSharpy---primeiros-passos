using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Executando o projeto 4 - Calculo da poupança");
            double valorInvestido = 1000;
            int contadormes = 1;

            //WHILE PARA CONTAGEM DE INVESTIMENTO
            while (contadormes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                if (contadormes == 1)
                {
                    Console.WriteLine("após" + contadormes + "mês você terá r$" + valorInvestido);
                }
                else
                {
                    Console.WriteLine("após" + contadormes + "meses você terá r$" + valorInvestido);
                }
                //contadormes = contadormes + 1;
                //contadormes += 1;
                contadormes++;
            }

            //FOR PARA CONTAGEM DE INVESTIMENTOS
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                if (contadorMes == 1)
                {
                    Console.WriteLine("Após" + contadorMes + "mês, você terá R$" + valorInvestido);
                }
                Console.WriteLine("Após" + contadorMes + "meses, você terá  R$" + valorInvestido);
            }

            //LAÇOS ENCADEADOS (IMPRIMINDO A METADE DE UMA ARVORE DE NATAL)
            for (int contadorLinha = 0; contadorLinha<10; contadorLinha++)
            {

                for(int contadorColuna = 0; contadorColuna<10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }

            //LAÇOS ENCADEADOS (IMPRIMINDO A METADE DE UMA ARVORE DE NATAL - OUTRA FORMA DE EXECUÇÃO)
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {

                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
