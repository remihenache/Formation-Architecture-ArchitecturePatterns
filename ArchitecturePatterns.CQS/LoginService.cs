namespace ArchitecturePatterns.CQS;

public class LoginService
{
    public string SayHello(string name)
    {
        return string.IsNullOrEmpty(name) ? "Bonjour inconnu" : $"Bonjour {name}";
    }
}