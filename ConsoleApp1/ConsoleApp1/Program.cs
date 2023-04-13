using ConsoleApp1.Entitites;
using System;
using System.Text;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Soma> list = new List<Soma>();

            Console.Write("Quantas operações você ira realizar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Qual a operação que voce deseja realizar? (Soma / Subtração / Divisão / Multiplicação / Raízes / Potência / Porcentagem): ");
                string resp = Console.ReadLine();

                switch (resp) 
                {
                    case "Soma" or "soma":

                        Console.Write("Digite o primeiro valor da soma: ");
                        double valor1Soma = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                        Console.Write("Digite o segundo valor da soma: ");
                        double valor2Soma = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Soma(valor1Soma, valor2Soma));

                        break;

                    case "Subtração" or "subtracao" or "subtração":

                        Console.Write("Digite o primeiro valor da subtração: ");
                        double valor1Subtracao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Digite o Segundo valor da subtração: ");
                        double valor2Subtracao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Subtração(valor1Subtracao, valor2Subtracao));

                        break;

                    case "Divisão" or "divisao":

                        Console.Write("Digite o primeiro valor da divisão: ");
                        double valor1Divisao = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Digite o segundo valor da divisão: ");
                        double valor2Divisao = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Divisão(valor1Divisao, valor2Divisao));

                        break;

                    case "Multiplicação" or "multiplicacao":

                        Console.Write("Digite o primeiro valor da multiplicação: ");
                        double valor1Multiplicacao = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Digite o segundo valor da multiplicação: ");
                        double valor2Multiplicacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Multiplicação(valor1Multiplicacao, valor2Multiplicacao));

                        break;

                    case "Raizes" or "raizes" or "raiz":

                        Console.Write("Digite o valor dentro da raiz: ");
                        double valor1Raizes = double.Parse(Console.ReadLine());

                        list.Add(new Raizes(valor1Raizes));

                        break;

                    case "Potencia" or "potencia" or "potência":

                        Console.Write("Digite o valor da base da potência: ");
                        double valor1Potencia = double.Parse(Console.ReadLine());

                        Console.Write("Digite o valor do expoente da potência: ");
                        double valor2Potencia = double.Parse(Console.ReadLine());

                        list.Add(new Potencia(valor1Potencia, valor2Potencia));

                        break;

                    case "Porcentagem" or "porcentagem":

                        Console.Write("Digite o valor que deseja sabe a porcentagem: ");
                        double valor1Porcentagem = double.Parse(Console.ReadLine());

                        Console.Write("Digite o valor da porcentagem: ");
                        double valor2Porcentagem = double.Parse(Console.ReadLine());

                        list.Add(new Porcentagem(valor1Porcentagem, valor2Porcentagem));

                        break;
                }
            }

            Console.WriteLine();

            foreach(Soma soma in list)
            {
                Console.WriteLine(soma.Resultado());
            }
        }
    }
}