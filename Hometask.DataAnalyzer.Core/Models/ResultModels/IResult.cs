namespace Hometask.DataAnalyzer.Core.Models.ResultModels;

public interface IResult<T>
{
    T Value { get; init; }
}