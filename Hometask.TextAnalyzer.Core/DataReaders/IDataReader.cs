using Hometask.DataAnalyzer.Core.Models.ResultModels;

namespace Hometask.TextAnalyzer.Core.DataReaders;

public interface IDataReader<T, TResult, TResultType> where TResult : IResult<TResultType>
{
    TResult GetResult(T data);
}