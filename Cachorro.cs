public class Cachorro:Animal
{
    public string raca { get; set; }
    public string nome { get; set; }

    public Cachorro(double altura, double peso, string raca, string nome):base(altura, peso)
    {
        this.raca = raca;
        this.nome = nome;
    }
    public virtual void Barulho()
    {
        Console.WriteLine("AuAu!!");
    }
}