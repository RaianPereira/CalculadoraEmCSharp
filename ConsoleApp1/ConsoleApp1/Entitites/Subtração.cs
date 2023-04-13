using System.Globalization;

namespace ConsoleApp1.Entitites
{
    class Subtração : Soma
    {
        public double Valor1Subtracao { get; set; }
        public double Valor2Subtracao { get; set; }

        public Subtração()
        {

        }

        public Subtração(double valor1Subtracao, double valor2Subtracao)
        {
            Valor1Subtracao = valor1Subtracao;
            Valor2Subtracao = valor2Subtracao;
        }

        public double Sub()
        {
            return Valor1Subtracao - Valor2Subtracao;
        }

        public override string Resultado()
        {
            return "O resultado da subtração é: "
                   + Sub().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
