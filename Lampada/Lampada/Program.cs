namespace Lampada
{
    public class Programs
    {
        static void Main(string[] args)
        {

            Lampada lampada1 = new Lampada();

            lampada1.Ligar();
            Console.WriteLine(lampada1.Estaligada());

            lampada1.Desligar();
            Console.WriteLine(lampada1.Estaligada());

            lampada1.Verde();
            Console.WriteLine(lampada1.VerCor());

        }
    }
}