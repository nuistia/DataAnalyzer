using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operations;

namespace Hometask.DataAnalyzer.Core.Operation.StringOperations.StringTextOperations;

public class StringNumSumOperation : IOperation<string, IntNumberResult>
{
    public IntNumberResult Process(string text)
    {
        ArgumentNullException.ThrowIfNull(text, nameof(text));

        var charNumbers = text.Where(char.IsNumber).ToList();
        var numbers = charNumbers.ConvertAll(c => int.Parse(c.ToString()));

        return new IntNumberResult(numbers.Sum());
    }
}
