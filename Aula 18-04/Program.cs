namespace Aula_18_04;
class Program
{
    static void Main(string[] args)
    {
       Banco b = new Banco();
        b.deposito(1000);
        b.saque(1600);
        b.AjustarLimite(500);
        b.imprime(b.emprestimo(1000,12));
        
    }
}
