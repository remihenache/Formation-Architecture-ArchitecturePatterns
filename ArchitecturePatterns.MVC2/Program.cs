namespace ArchitecturePatterns.MVC2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre nom :");
        var name = Console.ReadLine();

        var message = string.IsNullOrEmpty(name) ? "Bonjour inconnu" : $"Bonjour {name}";
        Console.WriteLine(message);
    }
}