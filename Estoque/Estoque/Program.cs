namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(24, 0, 70);
            p.imprimir();
        }
    }
}