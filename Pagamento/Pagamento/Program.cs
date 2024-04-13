namespace Pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pag pagamento = new Pag();


            Console.WriteLine("Digite o nome:");
            pagamento.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário:");
            pagamento.Sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as horas extras diurnas:");
            pagamento.HorasExtrasDi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite as horas extras noturnas:");
            pagamento.HorasExtrasNot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número de dependentes:");
            pagamento.Dependentes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas:");
            pagamento.Faltas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de descontos eventuais:");
            pagamento.Descontos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor gasto com refeições:");
            pagamento.Refeicoes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor dos vales retirados:");
            pagamento.ValesR = Convert.ToDouble(Console.ReadLine());

            pagamento.Calculo();
        }
    }
}
