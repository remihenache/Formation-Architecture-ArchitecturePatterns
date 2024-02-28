using System.ComponentModel;

namespace ArchitecturePatterns.MVVM;

public class LoginViewModel : INotifyPropertyChanged
{
    private string _input;
    public event PropertyChangedEventHandler PropertyChanged;

    public string Input
    {
        get => _input;
        set
        {
            if (_input != value)
            {
                _input = value;
                OnPropertyChanged(nameof(Input));
            }
        }
    }

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

}