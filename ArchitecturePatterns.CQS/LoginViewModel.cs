using System.ComponentModel;

namespace ArchitecturePatterns.CQS;

public class LoginViewModel : INotifyPropertyChanged
{
    private string _input;
    private string _message;
    private readonly LoginService _loginService = new LoginService();
    private LoginModel _model = new LoginModel();
    public event PropertyChangedEventHandler PropertyChanged;

    public string Input
    {
        get => _input;
        set
        {
            if (_input == value) return;
            _input = value;
            _model.Name = Input;
            OnPropertyChanged(nameof(Input));
            SayHello();
        }
    }

    public string Message
    {
        get => _message;
        set
        {
            if (_message != value)
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }
    }

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public void SayHello()
    {
        Message = _loginService.SayHello(Input);
    }
}