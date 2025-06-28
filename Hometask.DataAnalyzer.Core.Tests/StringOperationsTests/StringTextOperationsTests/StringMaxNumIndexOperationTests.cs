using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operation.StringOperations.StringTextOperations;

namespace Hometask.DataAnalyzer.Core.Tests.StringOperationsTests.StringTextOperationsTests;

[TestFixture]
public class StringMaxNumIndexOperationTests
{
    private readonly StringMaxNumIndexOperation _operation = new();

    [Test]
    [TestCase("Text1,skldk01dfngndfg9dfgjdjr4dfgm2klk1l;k2", 21)]
    [TestCase("   Text1With2Spa   ces2   ", 9)]
    public void Process_ValidText_ReturnCorrectIndexOfMaxNumber(string text, int expectedMaxNumIndex)
    {
        var expected = new IntNumberResult(expectedMaxNumIndex);

        var actual = _operation.Process(text);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
