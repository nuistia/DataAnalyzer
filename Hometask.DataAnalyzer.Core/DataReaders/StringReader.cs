using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operations;
using Hometask.TextAnalyzer.Core.DataReaders;

namespace Hometask.DataAnalyzer.Core.DataReaders;

public class StringReader : IDataReader<string, IntNumberResult>
{
    private readonly IOperation<string, IntNumberResult> _operation;

    public StringReader(IOperation<string, IntNumberResult> operation)
    {
        ArgumentNullException.ThrowIfNull(operation, nameof(operation));

        _operation = operation;
    }

    public IntNumberResult GetResult(string data)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(data, nameof(data));

        return _operation.Process(data);
    }
}
