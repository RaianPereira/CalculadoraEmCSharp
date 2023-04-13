using System;
using System.Globalization;

namespace ConsoleApp1.Entitites
{
    class Soma
    {
        public double Valor1Soma { get; set; }
        public double Valor2Soma { get; set; }


        public Soma()
        {

        }

        public Soma(double valor1Soma, double valor2Soma)
        {
            Valor1Soma = valor1Soma;
            Valor2Soma = valor2Soma;
        }

        public double Sum()
        {
            return Valor1Soma + Valor2Soma;
        }

        public virtual string Resultado()
        {
            return "O resultado da soma é: "
                   + Sum().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
