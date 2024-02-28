namespace ArchitecturePatterns.MVVM;

public class LoginPresenter
{
    private LoginModel _model;
    private ILoginViewPresenter _view;
    private readonly LoginService _loginService = new LoginService();

    public void SetModel(LoginModel model)
    {
        _model = model;
    }

    public void SetView(ILoginViewPresenter view)
    {
        _view = view;
        _view.SetPresenter(this);
    }

    public void SayHello()
    {
        var input = _view.GetInput();
        _model.Name = input;
        var message = _loginService.SayHello(input);
        _view.SetMessage(message);
    }
}