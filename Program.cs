using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double real;

            Console.Write("Real: ");
            real = Convert.ToDouble(Console.ReadLine());

            ObterDolar(real);
            ObterDollarCanadnse(real);
            ObterEuro(real);

            Console.Read();     

        }
        public static void ObterDolar(double real)
        {
            double dolar1 = 5.38;
            double conversor = real * dolar1;
            Console.WriteLine("Dolar = " + conversor);
        }
        public static void ObterDollarCanadnse(double real)
        {
            double cad = 3.90;
            double conversor = real * cad;
            Console.WriteLine("Dolar Canadense = " + conversor);
        }
        public static void ObterEuro(double real)
        {
            double euro = 5.96;
            double conversor = real * euro;
            Console.WriteLine("Euro = " + conversor);
        }
    }
}
