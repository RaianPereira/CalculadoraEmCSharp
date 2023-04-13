using System.Globalization;

namespace ConsoleApp1.Entitites
{
    class Porcentagem : Soma
    {

        public double Valor1Porcentagem { get; set; }
        public double Valor2Porcentagem { get; set; }


        public Porcentagem()
        {

        }

        public Porcentagem(double valor1Porcentagem, double valor2Porcentagem)
        {
            Valor1Porcentagem = valor1Porcentagem;
            Valor2Porcentagem = valor2Porcentagem;
        }

        public double Result()
        {
            return Valor1Porcentagem * (Valor2Porcentagem / 100);
        }

        public override string Resultado()
        {
            return "Resultado é: "
                    + Result().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
