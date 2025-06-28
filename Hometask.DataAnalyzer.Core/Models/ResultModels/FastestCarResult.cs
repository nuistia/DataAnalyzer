namespace Hometask.DataAnalyzer.Core.Models.ResultModels;

public class FastestCarResult : IOperationResult
{
    public int FirstIndex { get; init; }
    public int? LastIndex { get; init; } = null;
}
