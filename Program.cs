using System;
public class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();

        animal.tamanho = 0.42;
        animal.peso = 2.22;

        Console.WriteLine("Peso e tamanho do Animal");
        Console.WriteLine(animal.tamanho);
        Console.WriteLine(animal.peso);
        animal.Barulho();
        Console.WriteLine();


        Cachorro cachorro = new Cachorro(0.69, 7.52, "Loló da Pomeranea", "Bruna");
        Cachorro cachorro1 = new Cachorro(2, 50, "Pitbull", "Princesa");
        cachorro.Barulho();
        Console.WriteLine();

        Gato gato = new Gato(0.30, 2.43, "Persa", "Bartolomeo");
        Gato gato1 = new Gato(0.10, 0.50, "Preto", "Bruno");
        gato.Barulho();
        Console.WriteLine();

        List<Cachorro> cachorros = new List<Cachorro>();
        cachorros.Add(cachorro);
        cachorros.Add(cachorro1);

        List<Gato> gatos = new List<Gato>();
        gatos.Add(gato);
        gatos.Add(gato1);

        foreach (Cachorro item in cachorros)
        {
            Console.WriteLine($"O nome do cachorro é {item.nome}, da raça {item.raca}");
        }
        Console.WriteLine();

        foreach (Gato item in gatos)
        {
            Console.WriteLine($"O nome do gato é {item.nome}, da raça {item.raca}");
        }

        Console.ReadKey();
    }
}