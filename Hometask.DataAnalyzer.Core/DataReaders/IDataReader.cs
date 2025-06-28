using Hometask.DataAnalyzer.Core.Models.ResultModels;

namespace Hometask.TextAnalyzer.Core.DataReaders;

public interface IDataReader<T, TResult> where TResult : IOperationResult
{
    TResult GetResult(T data);
}