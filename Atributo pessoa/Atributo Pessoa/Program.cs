namespace Atributo_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Dada";
            p.Nascimento = new DateTime(2008, 3, 17);
            p.Altura = 1.70f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}