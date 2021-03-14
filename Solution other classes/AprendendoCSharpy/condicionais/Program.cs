using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto de condicionais");
            int idadeJoao = 18;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João é maior de idade. Pode entrar!");
            }
            else
            {
                Console.WriteLine("João é menor de idade. Não pode entrar");
            }
            Console.ReadLine();
        }
    }
}
