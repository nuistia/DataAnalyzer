using Hometask.DataAnalyzer.Core.Models.CarModels;
using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operations;

namespace Hometask.DataAnalyzer.Core.Operation.ArrayOperations.CarArrayOperations;

public class ArrayFastestCarOperation : IOperation<Car[], FastestCarResult>
{
    public FastestCarResult Process(Car[] cars)
    {
        ArgumentNullException.ThrowIfNull(cars, nameof(cars));

        FastestCarResult result;

        var highestSpeed = cars.MaxBy(c => c.Speed).Speed;

    }
}
