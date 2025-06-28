using Hometask.DataAnalyzer.Core.Models.ResultModels;

namespace Hometask.DataAnalyzer.Core.Operations;

public interface IOperation<T, TResult> where TResult : IOperationResult
{
    TResult Process(T data);
}