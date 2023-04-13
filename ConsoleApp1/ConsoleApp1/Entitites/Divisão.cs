using System.Globalization;

namespace ConsoleApp1.Entitites
{
    class Divisão : Soma
    {
        public double Valor1Divisao { get; set; }
        public double Valor2Divisao { get; set; }


        public Divisão() 
        {
            
        }

        public Divisão(double valor1Divisao, double valor2Divisao)
        {
            Valor1Divisao = valor1Divisao;
            Valor2Divisao = valor2Divisao;
        }

        public double Div()
        {
            return Valor1Divisao / Valor2Divisao;
        }

        public override string Resultado()
        {
            return "O resultado da divisão é: "
                   + Div().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
