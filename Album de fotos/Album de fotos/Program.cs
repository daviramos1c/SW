namespace Album_de_fotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando numero de paginas:");
            Console.WriteLine("");

            Album album= new Album();

            Console.WriteLine(album.NumPag());

        }
    }
}