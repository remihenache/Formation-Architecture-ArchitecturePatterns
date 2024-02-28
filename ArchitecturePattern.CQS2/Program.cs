using ArchitecturePattern.CQS2.Mediator;

namespace ArchitecturePattern.CQS2;

class Program
{
    static void Main(string[] args)
    {
        var model = new LoginModel();
        var loginService = new LoginService();
     
        var mediator = new SimpleMediator();

        Console.WriteLine("Entrez votre nom :");
        var name = Console.ReadLine();

        // mediator.ExecuteCommand(new CommandType() { Value = value };
        // var message = mediator.ExecuteQuery<QueryType, string>(new QueryType());
        //Console.WriteLine(message);
    }
}