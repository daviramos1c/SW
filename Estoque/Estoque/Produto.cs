using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Produto
    {
        private int codigo { get; set; }
        private string? nome { get; set; }
        private int estoque { get; set; }
        private double valor { get; set; }

        public Produto(int cod, int est, double val)
        {
            cod = codigo;
            est = estoque;
            val = valor;
        }

        public void entrada(int qtd)
        {
            estoque = estoque + qtd;
            Console.WriteLine("Entrada de" + qtd);
        }

        public void venda(int qtd)
        {
            estoque = estoque - qtd;
            Console.WriteLine("Venda de" + qtd);
        }

        public void imprimir()
        {
            Console.WriteLine("Dados do produto: ");
            Console.WriteLine("Cod: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nome: " + estoque);
            Console.WriteLine("Valor: " + valor);
        }
    }
}
