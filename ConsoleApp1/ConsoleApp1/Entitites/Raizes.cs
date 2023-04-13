using System.Globalization;
namespace ConsoleApp1.Entitites
{
    class Raizes : Soma
    {

        public double Valor1Raiz { get; set; }


        public Raizes()
        {

        }

        public Raizes(double valor1Raiz)
        {
            Valor1Raiz = valor1Raiz;
        }


        public double Result()
        {
            return Math.Sqrt(Valor1Raiz);
        }


        public override string Resultado()
        {
            return "Resultado da raiz é: "
                    + Result().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
