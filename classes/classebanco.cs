namespace classes;

class Classebanco
{

    public bool sacar;
    public bool deposito;
    public bool transacao;
    public bool tirar;

    public String agencia;
    public String tipo;
    public int valor;
    public int conta;
    public void Saque(){
        sacar = true;
    }
    public void Deposito(){
        deposito = false;
    } 
    public void Transacao(){
        transacao= true;
    } 
    public void Extrato(){
        tirar = true;
    } 
}
