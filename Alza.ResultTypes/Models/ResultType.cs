namespace Alza.ResultTypes.Models;

public class ResultType<T>
{
    public T? Result { get; set; }

    public required string Status { get; set; }
    
    public string? Message { get; set; }
}