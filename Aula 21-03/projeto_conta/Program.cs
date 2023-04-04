namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco :)");
        Conta c = new Conta();
        c.Depositar(1000);
        c.Sacar(800);
        c.AjustarLimite(500);

        double valorLocal = c.MostrarSaldo();


        Console.WriteLine("Seu saldo total é de: " + valorLocal);
    }
}
