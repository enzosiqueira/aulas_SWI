namespace ex01;
class Program
{
    static void Main(string[] args){

    Animal a1 = new Animal();
    Cao c1 = new Cao();
    Homem h1 = new Homem();
    Gato g1 = new Gato();

    Console.WriteLine("O Cão faz: " + c1.EmitirSom());
    Console.WriteLine("O Homem faz: " + h1.EmitirSom());
    Console.WriteLine("O Gato faz: " + g1.EmitirSom());

    }
}
