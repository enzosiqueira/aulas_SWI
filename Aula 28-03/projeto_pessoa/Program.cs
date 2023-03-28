namespace projeto_pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Enzo",16);
        //p1.InsereNome("Cristiano");
        //p1.InsereSobreNome("Ronaldo");
        //p1.InsereIdade(38);

        p1.MostraDados();
    }
}
