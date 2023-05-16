namespace ex01;
class Cao:Animal
{
    public string? Som{get;set;}

    public override string EmitirSom(){
        return base.EmitirSom() + "Au";
    } 
}
