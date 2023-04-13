using System.Globalization;

namespace ConsoleApp1.Entitites
{
    class Multiplicação : Soma
    {
        public double Valor1Multiplicacao { get; set; }
        public double Valor2Multiplicacao { get; set; }

        public Multiplicação() 
        {
            
        }

        public Multiplicação(double valor1Multiplicacao, double valor2Multiplicacao)
        {
            Valor1Multiplicacao = valor1Multiplicacao;
            Valor2Multiplicacao = valor2Multiplicacao;
        }


        public double Multi()
        {
            return Valor1Multiplicacao * Valor2Multiplicacao;
        }

        public override string Resultado()
        {
            return "O resultado da multiplicação é: "
                   + Multi().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
