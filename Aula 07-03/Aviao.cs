    namespace aula_07_03_23;
class Aviao
{
    public string modelo="";
    public string marca="";
    public int altitude;
    public int velocidade;

    public void acelerar(){
        Console.WriteLine("Estou acelerando!!");
   }
    
     public void acelerarParemetro(string valor){
        Console.WriteLine("Estou acelerando!! " + valor);
     }   

     public string seila(){
        return "Oi doidão";
     }   

     public int somar(int a, int b){
        return a+b;
     }
    
}