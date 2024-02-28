using System.ComponentModel;

namespace ArchitecturePatterns.CQS;

public class LoginView
{
    private readonly LoginViewModel _viewModel;

    public LoginView(LoginViewModel viewModel)
    {
        _viewModel = viewModel;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(LoginViewModel.Message))
        {
            Console.WriteLine(_viewModel.Message);
        }
    }

    public void GetUserInput()
    {
        Console.WriteLine("Entrez votre nom :");
        _viewModel.Input = Console.ReadLine();
    }
}