public class Animal
{
    public double tamanho { get; set; }
    public double peso { get; set; }
    public Animal()
    {
    }
    public Animal(double tamanho, double peso)
    {
        this.tamanho = tamanho;
        this.peso = peso;
    }
    public void Barulho()
    {
        Console.WriteLine("Barulho!!!");
    }
}