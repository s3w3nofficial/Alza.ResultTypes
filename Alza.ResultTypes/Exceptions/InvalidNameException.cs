namespace Alza.ResultTypes.Exceptions;

public class InvalidNameException : Exception
{
    public InvalidNameException()
        : base("Name is invalid!")
    {
        
    }
}