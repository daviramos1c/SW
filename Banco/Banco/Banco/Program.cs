namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.mudarlimite(700);
            conta.depositar(500); 
            Console.WriteLine("Seu saldo é de R$" + conta.versaldo() + " e seu limite é de R$" + conta.verlimite()); //inicio

            conta.depositar(500); //valor inicial
            Console.WriteLine("você fez um depósito e está com o saldo de R$" + conta.versaldo()); //mostra saldo

            conta.sacar(200); //saque
            Console.WriteLine("você fez um saque e está com o saldo de R$" + conta.versaldo()); //mostra saldo



        }
    }
}