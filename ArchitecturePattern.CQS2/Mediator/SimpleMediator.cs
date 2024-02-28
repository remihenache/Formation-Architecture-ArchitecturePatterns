namespace ArchitecturePattern.CQS2.Mediator;

public class SimpleMediator : IMediator
{
    // private readonly SampleCommandHandler sampleCommandHandler;
    //
    // public SimpleMediator(SampleCommandHandler sampleCommandHandler)
    // {
    //     this.sampleCommandHandler = sampleCommandHandler;
    // }

    public void ExecuteCommand<T>(T command) where T : ICommand
    {
        // if (command is SampleCommand sampleCommand)
        // {
        //     sampleCommandHandler.Execute(sampleCommand);
        // }
    }

    public TResult ExecuteQuery<T, TResult>(T query)
        where T : IQuery<TResult> 
        where TResult : class
    {
        // meme logique que dans le ExecuteCommand
        
        throw new InvalidOperationException("Query type not supported.");
    }
}