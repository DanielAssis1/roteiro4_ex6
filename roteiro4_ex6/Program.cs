using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 5.00, lucroesperado=0, ingressos1 = 120;
            
            Console.WriteLine(" |Valor do Ingresso|  |Lucro máximo|  |Qnt. Ingressos Vendidos| ");

            while (valor1 >= 1.00)
            {
                lucroesperado = (valor1*ingressos1)-200; 

                Console.WriteLine("        R$" +valor1+"               R$"+lucroesperado+"           "+ingressos1+" ingressos.\n");
                ingressos1 += 26;
                valor1 -= 0.50;
            }
            Console.ReadKey();
        }
    }
}
