using Hometask.DataAnalyzer.Core.Models.BookModels;
using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operation.ArrayOperations.BooksArrayOperations;

namespace Hometask.DataAnalyzer.Core.Tests.ArrayOperationsTests.BooksArrayOperationsTests;

[TestFixture]
public class ArrayThickestBookOperationTests
{
    private readonly Book[] _testBooks = BookTestData.GetTestBooks();
    private readonly ArrayThickestBookOperation _operation = new();

    [Test]
    public void Process_ValidBooks_ReturnsFirstThickestBookIndex()
    {
        IntNumberResult expectedResult = new(500);

        var actual = _operation.Process(_testBooks);

        Assert.That(expectedResult.Value, Is.EqualTo(actual.Value));
    }
}
