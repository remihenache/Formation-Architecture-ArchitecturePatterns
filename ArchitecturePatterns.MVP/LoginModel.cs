namespace ArchitecturePatterns.MVP;

public class LoginModel
{
    private string _name;
    private bool _changed = false;
    private List<IObserver> _observers = new List<IObserver>();
    private readonly LoginService _loginService = new LoginService();

    public void SetName(string name)
    {
        _name = name;
        _changed = true;
        NotifyObservers();
    }

    public string GetMessage()
    {
        return _loginService.SayHello(_name);
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    private void NotifyObservers()
    {
        if (!_changed) return;
        _changed = false;
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}