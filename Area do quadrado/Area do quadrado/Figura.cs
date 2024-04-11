using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_do_quadrado
{
    public class Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Area { get; set; }


        public string Calculo()
        {
            Console.WriteLine("Digite a base:");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a altura:");
            Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            string tipo = "";

            Area = Base * Altura;

            if (Base == Altura)
            {
                tipo = "quadrado";
            }
            else 
            {
                tipo = "retângulo";
            }
           

            string resultado = "A área da figura é " + Area + ", e a figura é um ";
            resultado += tipo;
            

            return resultado;
        }

        public string Info()
        {
            string info = "A base é " + Base + ", e a altura é " + Altura;

            return info;
        }

    }
}
