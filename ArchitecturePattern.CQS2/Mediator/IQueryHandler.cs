namespace ArchitecturePattern.CQS2.Mediator;

public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
{
    TResult Execute(TQuery query);
}