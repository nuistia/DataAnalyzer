using Hometask.DataAnalyzer.Core.Models.CarModels;
using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operation.ArrayOperations.CarArrayOperations;

namespace Hometask.DataAnalyzer.Core.Tests.ArrayOperationsTests.CarArrayOperationsTests;

[TestFixture]
public class ArrayFastestCarOperationTests
{
    private readonly Car[] _testCars = CarTestData.GetTestCars();
    private readonly ArrayFastestCarOperation _operation = new();

    [Test]
    public void Process_ValidBooks_ReturnsFirstThickestBookIndex()
    {
        FastestCarResult expectedResult = new(4, 36);

        var actual = _operation.Process(_testCars);

        Assert.That(expectedResult.FirstIndex, Is.EqualTo(actual.FirstIndex));
        Assert.That(expectedResult.LastIndex, Is.EqualTo(actual.LastIndex));
    }
}
