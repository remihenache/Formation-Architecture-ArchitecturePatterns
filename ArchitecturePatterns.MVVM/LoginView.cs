using System.ComponentModel;

namespace ArchitecturePatterns.MVVM;

public class LoginView : ILoginViewPresenter
{
    private LoginPresenter _presenter;
    private readonly LoginViewModel _viewModel;

    public LoginView(LoginViewModel viewModel)
    {
        _viewModel = viewModel;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        
    }
    
    public void SetPresenter(LoginPresenter presenter)
    {
        _presenter = presenter;
    }

    public string GetInput()
    {
        Console.WriteLine("Entrez votre nom :");
        return Console.ReadLine();
    }

    public void SetMessage(string text)
    {
        Console.WriteLine(text);
    }

    public void HandleSayHello()
    {
        _presenter.SayHello();
    }
}