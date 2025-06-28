using Hometask.DataAnalyzer.Core.Models.BookModels;
using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operations;

namespace Hometask.DataAnalyzer.Core.Operation.ArrayOperations.BooksArrayOperations;

public class ArrayThickestBookOperation : IOperation<Book[], IntNumberResult>
{
    public IntNumberResult Process(Book[] books)
    {
        ArgumentNullException.ThrowIfNull(books, nameof(books));

        var thickestBook = books.MaxBy(b => b.Thickness);

        return new IntNumberResult(thickestBook.Pages);
    }
}
