namespace ArchitecturePatterns.CQS;

class Program
{
    static void Main(string[] args)
    {
        var viewModel = new LoginViewModel();
        var view = new LoginView(viewModel);

        // Simuler l'interaction de l'utilisateur continuellement
        while (true)
        {
            view.GetUserInput();
        }
    }
}