using Hometask.DataAnalyzer.Core.Models.ResultModels;

namespace Hometask.DataAnalyzer.Core.Operations;

public interface IOperation<T, TResult, TResultType> where TResult : IResult<TResultType>
{
    TResult Process(T data);
}