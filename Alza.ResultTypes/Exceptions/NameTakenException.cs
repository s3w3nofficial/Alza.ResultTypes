namespace Alza.ResultTypes.Exceptions;

public class NameTakenException : Exception
{
    public NameTakenException()
        : base("Name is already taken!")
    {
        
    }
}