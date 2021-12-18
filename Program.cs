using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpProva
{

    class Program
    {

        public static void Main(string[] args)
        {

            double calculaPecaUm;
            double calculaPecaDois;

            CalculaPecas pecaUm = new CalculaPecas();
            CalculaPecas pecaDois = new CalculaPecas();

            pecaUm.CodigoPeca = 1;
            pecaUm.QuantidadePeca = 2;
            pecaUm.ValorPeca = 2.50;

            pecaDois.CodigoPeca = 2;
            pecaDois.QuantidadePeca = 4;
            pecaDois.ValorPeca = 5.50;

            calculaPecaUm = pecaUm.QuantidadePeca * pecaUm.ValorPeca;
            calculaPecaDois = pecaDois.QuantidadePeca * pecaDois.ValorPeca;

            Console.WriteLine($"O valor da peça {pecaUm.CodigoPeca} é: {calculaPecaUm}");
            //double.TryParse(Console.ReadLine(), out calculaPecaUm);

            Console.WriteLine($"O valor da peça {pecaDois.CodigoPeca} é:{calculaPecaDois}");
            //double.TryParse(Console.ReadLine(), out calculaPecaDois);


            Console.WriteLine($"O resultado da soma do código {pecaUm.CodigoPeca} com {pecaDois.CodigoPeca} é: {calculaPecaUm + calculaPecaDois}");




        }
    }
}
