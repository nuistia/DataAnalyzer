using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operation.StringOperations.StringTextOperations;

namespace Hometask.DataAnalyzer.Core.Tests.StringOperationsTests.StringTextOperationsTests;

[TestFixture]
public class StringNumSumOperationTests
{
    private readonly StringNumSumOperation _operation = new();

    [Test]
    [TestCase("Text1,skldk01dfngndfg9dfgjdjr4dfgm2klk1l;k2", 20)]
    [TestCase("   Text1With2Spa   ces2   ", 5)]
    public void Process_ValidText_ReturnsCorrectSum(string text, int expectedSum)
    {
        var expected = new IntNumberResult(expectedSum);

        var actual = _operation.Process(text);

        Assert.That(expected, Is.EqualTo(actual));
    }
}
