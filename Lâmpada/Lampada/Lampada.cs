using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void Ligar()
        {
            Ligada = true;
        }

        public void Desligar()
        {
            Ligada = false;
        }

        public bool Estaligada()
        { 
            return Ligada; 
        }

        public void Verde()
        {
            Cor = "verde";
        }

        public void Azul()
        {
            Cor = "azul";
        }

        public string VerCor()
        {
            return Cor;
        }

        public void Pot50()
        {
            Potencia = 50;
        }

        public void Pot100()
        {
            Potencia = 100;
        }

        public int VerPot()
        { 
            return Potencia; 
        }
    }
}
