using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");

            //DECLARANDO VARIÁVEIS INT (32 BITS)
            int idade = 32;
            Console.WriteLine(idade);
            idade = 10 + 5 * 2; //A linguagem da prioridade para a multiplicação
            Console.WriteLine("sua idade é: " + idade + "anos");
            Console.ReadLine();

            //DECLARANDO VARIAVEIS FLOAT 
            double numero;
            //numero = 15 / 2; //Mesmo sendo double, resultará no valor 7 
            //Para resultar no 7,5, devemos utilizar o valor 15.0 ou 2.0
            numero = 15.0 / 2;
            Console.WriteLine(numero);
            numero = 5.0 / 3;
            Console.ReadLine();

            //DECLARANDO VARIAVEIS LONG (64 BITS)
            long idadeDoUniverso;
            idadeDoUniverso = 1300000000000;
            Console.WriteLine(idadeDoUniverso);

            //DECLARANDO VARIAVEIS SHORT (16 BITS)
            short quantidadeDoEstoque = 150;
            Console.WriteLine(quantidadeDoEstoque);

            ////DECLARANDO VARIAVEIS FLOAT (baixa precisão de casa decimal)
            float altura = 1.80f; //Adicionar o f ao final para indicar pro compilador que de fato queremos o float, pois esse não é usual
            Console.WriteLine(altura);

            //DECLARANDO VARIAVEIS character (16 BITS)
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra + 1); //IMPRIME 66
            primeiraLetra = (char)(65 + 1);
            Console.WriteLine(primeiraLetra); //IMPRIME B

            //DECLARANDO VARIAVEIS character ()
            string titulo = "Hello!" +
                "TESTE" +
                "TESTE"; //IMPRIME Hello Teste Teste na mesma linha
            Console.WriteLine(titulo);
            Console.ReadLine();

            string tituloComQuebra = @"Hello!
            - Teste
            - Teste."; //IMPRIME Hello Teste Teste com quebra de linha
            Console.WriteLine(tituloComQuebra);
            Console.ReadLine();

            //CONVERSÃO DE VARIAVEIS 
            double salario = 1200.50;
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; //casting
            Console.WriteLine(salarioEmInteiro);
            Console.ReadLine();
        }
    }
}
