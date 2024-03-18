namespace ArchitecturePatterns.CQS;

public class LoginModel
{
    private readonly LoginService _loginService = new LoginService();
    public string Name { get; set; }
    
    public string GetMessage()
    {
        return _loginService.SayHello(Name);
    }
}