using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class hotel
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Digite o seu salario bruto");
           double sb = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quantos filhos você tem:");
            double nf = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do vale alimentação");
            double vl = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas extras feitas: ");
            double nh = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a recebido por filho:");
            double vf = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor da hora extra:");
            double vh = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a procentagem do inss");
            double vinss = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite A porcnetegem do IRPF");
            double virpf = double.Parse(Console.ReadLine());


            double valor = sb + (nf * vf) + vl + (nh * vh) - vinss - virpf;

            Console.WriteLine("O valor final de seu salario e: " + valor.ToString("c"));
            Console.ReadKey();


            

        }
    }
}
