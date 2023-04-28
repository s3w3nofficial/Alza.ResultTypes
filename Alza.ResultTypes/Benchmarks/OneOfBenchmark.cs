using Alza.ResultTypes.Exceptions;
using Alza.ResultTypes.Models;
using BenchmarkDotNet.Attributes;
using OneOf;

namespace Alza.ResultTypes.Benchmarks;

public class OneOfBenchmark
{
    private OneOf<User, InvalidNameException, NameTakenException> CreateUser()
    {
        return new User();
    }
    
    private OneOf<User, InvalidNameException, NameTakenException> CreateUserException()
    {
        return new InvalidNameException();
    }
    
    [Benchmark]
    public void OneOfCreation()
    {
        var newUser = CreateUser();
    }
    
    [Benchmark]
    public void OneOfCreationException()
    {
        var newUser = CreateUserException();
    }

    [Benchmark]
    public void OneOfGetUser()
    {
        var newUser = CreateUser();

        var result = newUser.Match<ResultType<User>>(user => new ResultType<User>
        {
            Result = user,
            Status = "SUCCESS"
        }, invalidName => new ResultType<User>
        {
            Result = null,
            Status = "FAILURE",
            Message = invalidName.Message
        }, nameTaken => new ResultType<User>
        {
            Result = null,
            Status = "FAILURE",
            Message = nameTaken.Message
        });
    }
    
    [Benchmark]
    public void OneOfGetException()
    {
        var newUser = CreateUserException();

        var result = newUser.Match<ResultType<User>>(user => new ResultType<User>
        {
            Result = user,
            Status = "SUCCESS"
        }, invalidName => new ResultType<User>
        {
            Result = null,
            Status = "FAILURE",
            Message = invalidName.Message
        }, nameTaken => new ResultType<User>
        {
            Result = null,
            Status = "FAILURE",
            Message = nameTaken.Message
        });
    }
}