using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operation.StringOperations;

namespace Hometask.DataAnalyzer.Core.Tests.StringOperationsTests;

[TestFixture]
public class StringMaxNumOperationTests
{
    private readonly StringMaxNumOperation _operation = new();

    [Test]
    [TestCase("Text1,skldk01dfngndfg9dfgjdjr4dfgm2klk1l;k2", 9)]
    [TestCase("   Text1With2Spa   ces2   ", 2)]
    public void Process_ValidText_ReturnsCorrectMaxNumber(string text, int expectedNum)
    {
        var expected = new IntNumberResult(expectedNum);

        var actual = _operation.Process(text);

        Assert.That(expected, Is.EqualTo(actual));
    }
}
