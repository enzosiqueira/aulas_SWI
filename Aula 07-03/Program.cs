namespace aula_07_03_23;
class Program
{
    static void Main(string[] args)
    {
        //Console.ReadLine();
        //Instancia de um objeto da classe aviao
        Aviao shebera = new Aviao();

        //Usando atributos e/ou metodos da classe pelo objeto criado
        shebera.acelerar();

        //Usando metodo sem retorno e com parametro
        shebera.acelerarParemetro("David");

        //Retorno sem parametro
        Console.WriteLine(shebera.seila());

        //Metodo com retorno e com  parametros
        Console.WriteLine(shebera.somar(10, 20));
    }
}
