namespace ex01;
class Gato:Animal
{

    public string? Som {get;set;}

    public override string EmitirSom(){
        return base.EmitirSom() + "Miau";
    } 
}
