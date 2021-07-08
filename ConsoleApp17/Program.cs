using System;
using System.Globalization;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            double salario, vendas, comissão;
            x = Console.ReadLine();

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissão = vendas * 0.15 + salario;

            Console.WriteLine("TOTAL = R$ " + comissão.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
