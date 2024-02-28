namespace ArchitecturePatterns.MVP;

public class LoginController
{
    private LoginModel _model;
    private LoginView _view;

    public void SetModel(LoginModel model)
    {
        _model = model;
    }

    public void SetView(LoginView view)
    {
        _view = view;
        _view.SetController(this);
    }

    public void SayHello(string name)
    {
        _model.SetName(name);
    }
}