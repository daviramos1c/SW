namespace Lampada
{
    public class Programs
    {
        static void Main(string[] args)
        {

            Lampada lampada1 = new Lampada();

            lampada1.Ligar();
            Console.WriteLine("A lâmpada está ligada: " + lampada1.Estaligada());

            lampada1.Desligar();
            Console.WriteLine("A lâmpada está ligada: " + lampada1.Estaligada());

            lampada1.Verde();
            Console.WriteLine("A cor da lâmpada é: " + lampada1.VerCor());

            lampada1.Azul();
            Console.WriteLine("A cor da lâmpada é: " + lampada1.VerCor());

            lampada1.Pot50();
            Console.WriteLine("A potência da lâmpada é: " + lampada1.VerPot());

            lampada1.Pot100();
            Console.WriteLine("A potência da lâmpada é: " + lampada1.VerPot());


        }
    }
}