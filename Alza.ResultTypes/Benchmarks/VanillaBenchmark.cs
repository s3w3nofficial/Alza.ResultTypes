using Alza.ResultTypes.Exceptions;
using Alza.ResultTypes.Models;
using BenchmarkDotNet.Attributes;

namespace Alza.ResultTypes.Benchmarks;

public class VanillaBenchmark
{
    private User CreateUser()
    {
        return new User();
    }

    private User CreateUserException()
    {
        throw new InvalidNameException();
    }

    [Benchmark]
    public void VanillaCreation()
    {
        var newUser = CreateUser();
    }

    [Benchmark]
    public void VanillaCreationException()
    {
        var newUser = CreateUserException();
    }

    [Benchmark]
    public void VanillaGetUser()
    {
        ResultType<User> result;

        try
        {
            var newUser = CreateUser();

            result = new ResultType<User>
            {
                Result = newUser,
                Status = "SUCCESS"
            };
        }
        catch (InvalidNameException invalidNameException)
        {
            result = new ResultType<User>
            {
                Result = null,
                Status = "FAILURE",
                Message = invalidNameException.Message
            };
        }
        catch (NameTakenException nameTakenException)
        {
            result = new ResultType<User>
            {
                Result = null,
                Status = "FAILURE",
                Message = nameTakenException.Message
            };
        }
    }
    
    [Benchmark]
    public void VanillaGetException()
    {
        ResultType<User> result;

        try
        {
            var newUser = CreateUserException();

            result = new ResultType<User>
            {
                Result = newUser,
                Status = "SUCCESS"
            };
        }
        catch (InvalidNameException invalidNameException)
        {
            result = new ResultType<User>
            {
                Result = null,
                Status = "FAILURE",
                Message = invalidNameException.Message
            };
        }
        catch (NameTakenException nameTakenException)
        {
            result = new ResultType<User>
            {
                Result = null,
                Status = "FAILURE",
                Message = nameTakenException.Message
            };
        }
    }
}