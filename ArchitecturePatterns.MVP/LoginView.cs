namespace ArchitecturePatterns.MVP;

public class LoginView : IObserver
{
    private LoginController _controller;

    public void SetController(LoginController controller)
    {
        _controller = controller;
    }

    public void Update(LoginModel model)
    {
        Console.WriteLine(model.GetMessage());
    }

    public void GetInputAndGreet()
    {
        Console.WriteLine("Entrez votre nom :");
        var input = Console.ReadLine();
        _controller.SayHello(input);
    }
}