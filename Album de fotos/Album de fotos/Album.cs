using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Album_de_fotos
{
    internal class Album
    {
        public double NumFotos { get; set; }
        public double FotosPag { get; set; }
        public double resto { get; set; }

        public string NumPag()
        {

            Console.WriteLine("Digite quantas fotos você vai usar");
            NumFotos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantas fotos por página você quer");
            FotosPag = Convert.ToDouble(Console.ReadLine());

            resto = NumFotos % FotosPag;

            if (resto == 1)
            {
                return "Você pode colocar " + NumFotos / FotosPag + " e vai sobrar " + resto + " fotos";
            }
            else
            {
                return "Você pode colocar " + NumFotos / FotosPag + " fotos por página";
            }
        }
    }

}
