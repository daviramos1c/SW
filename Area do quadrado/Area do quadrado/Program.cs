namespace Area_do_quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculando Área:");
            Console.WriteLine("");

            Figura figura = new Figura();

            Console.WriteLine(figura.Calculo());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(figura.Info());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}