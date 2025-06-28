namespace Hometask.DataAnalyzer.Core.Models.BookModels;

public record Book(string Name, int Pages, double PageThickness = 0.1) 
{ 
    public double Thickness => Pages * PageThickness;
}
