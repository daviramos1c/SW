using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributo_Pessoa
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public float Altura { get; set; }

        public string? Vernome()
        {
            return Nome;
        }

        public DateTime Verdata()
        {
            return Nascimento;
        }

        public float Veraltura()
        {
            return Altura;
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - Nascimento.Year;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + Nascimento);
            Console.WriteLine("Altura: " + Altura);
        }
    }
}
