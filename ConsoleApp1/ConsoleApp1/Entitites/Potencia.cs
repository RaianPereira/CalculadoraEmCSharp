using System.Globalization;

namespace ConsoleApp1.Entitites
{
    class Potencia : Soma
    {
        public double Valor1Potencia { get; set; }
        public double Valor2Potencia { get; set; }


        public Potencia()
        {

        }

        public Potencia(double valor1Potencia, double valor2Potencia)
        {
            Valor1Potencia = valor1Potencia;
            Valor2Potencia = valor2Potencia;
        }

        public double Result()
        {
            return Math.Pow(Valor1Potencia, Valor2Potencia);
        }


        public override string Resultado()
        {
            return "O resultado da potência é: "
                    + Result().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
