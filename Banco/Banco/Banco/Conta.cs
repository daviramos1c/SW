using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private string? agencia { get; set; }
        private string? conta { get; set; }
        private float saldo { get; set; }
        private float limite { get; set; }

        public void sacar(float valorsaque)
        {
            saldo = saldo - valorsaque;
        }

        public void depositar(float valordeposito)
        {
            saldo = saldo + valordeposito;
        }

        public void mudarlimite(float valorlimite)
        {
            limite = limite + valorlimite;
        }

        public float versaldo()
        {
            return saldo;
        }

        public float verlimite()
        {
            return limite;
        }
    }
}
