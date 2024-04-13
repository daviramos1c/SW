using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    class Pag
    {

        public string? Nome { get; set; }
        public double Sal { get; set; }
        public int Dependentes { get; set; }
        public int Faltas { get; set; }
        public int HorasExtrasDi { get; set; }
        public int HorasExtrasNot { get; set; }
        public double Descontos { get; set; }
        public double Refeicoes { get; set; }
        public double ValesR { get; set; }

        private const double SalarioMinimo = 1000.00;
        private const double Taxa = 0.08;
        private const double RendaTaxa = 0.08;



        public void Calculo()
        {

            double horasExtras = (HorasExtrasDi * Sal / 160) + (HorasExtrasNot * 1.2 * Sal / 160);
            double salarioFamilia = Dependentes * 0.05 * SalarioMinimo;
            double salarioBruto = Sal + horasExtras + salarioFamilia;
            double inamps = Taxa * Sal;
            double faltasDesconto = Faltas * Sal / 160;
            double refeicoes = Refeicoes;
            double vales = ValesR;
            double descontoTotal = inamps + faltasDesconto + refeicoes + vales + Descontos + (RendaTaxa * salarioBruto);
            double salarioLiquido = salarioBruto - descontoTotal;

            Console.WriteLine($"Nome: " + Nome);
            Console.WriteLine($"Salário: " + Sal);
            Console.WriteLine($"Horas Extras: " + horasExtras);
            Console.WriteLine($"Salário Família: " + salarioFamilia);
            Console.WriteLine($"Salário Bruto: " + salarioBruto);
            Console.WriteLine($"Desconto INAMPS: " + inamps);
            Console.WriteLine($"Desconto por Faltas: " + faltasDesconto);
            Console.WriteLine($"Desconto por Refeições: " + refeicoes);
            Console.WriteLine($"Desconto por Vales: " + vales);
            Console.WriteLine($"Descontos Eventuais: " + Descontos);
            Console.WriteLine($"Imposto de Renda: " + RendaTaxa * salarioBruto);
            Console.WriteLine($"Desconto Total: " + descontoTotal);
            Console.WriteLine($"Salário Líquido: " + salarioLiquido);

        }
    }
}
