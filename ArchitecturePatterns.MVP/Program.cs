namespace ArchitecturePatterns.MVP;

class Program
{
    static void Main(string[] args)
    {
        var model = new LoginModel();
        var view = new LoginView();
        var controller = new LoginController();

        model.AddObserver(view);
        controller.SetModel(model);
        controller.SetView(view);

        view.GetInputAndGreet();
    }
}