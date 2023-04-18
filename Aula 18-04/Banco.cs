namespace Aula_18_04;
class Banco
{
    public double saldo {get;set;}
    public double valor {get;set;}
    public int prazo{get;set;}



    public void deposito(double d){
        this.saldo += d;
    }

    public void saque(double s){
        this.saldo -= s;
    }

    public string emprestimo(double v, int p){
        this.valor = v;
        this.prazo = p;
        double total = this.valor/this.prazo;
        double juros = this.valor*0.06;
        double ajustado = total + juros;
        string final = "O valor a ser pago é de: "+ ajustado;  
        return final;
    }

    public void imprime(string texto){
    Console.WriteLine(texto);
    }
}

