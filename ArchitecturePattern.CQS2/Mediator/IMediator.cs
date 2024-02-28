namespace ArchitecturePattern.CQS2.Mediator;

public interface IMediator
{
    void ExecuteCommand<T>(T command) where T : ICommand;
    TResult ExecuteQuery<T, TResult>(T query) 
        where T : IQuery<TResult>
        where TResult : class;
}