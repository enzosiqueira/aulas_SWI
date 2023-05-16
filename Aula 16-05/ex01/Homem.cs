namespace ex01;
class Homem:Animal
{

    public string? Som{get;set;}

    public override string EmitirSom(){
        return base.EmitirSom() + "Oi";
    } 
}
