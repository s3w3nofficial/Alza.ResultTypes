using Alza.ResultTypes.Models;
using BenchmarkDotNet.Attributes;

namespace Alza.ResultTypes.Benchmarks;

public class ResultTypeBenchmark
{
    private ResultType<User> CreateUser()
    {
        return new ResultType<User>
        {
            Result = new User(),
            Status = "SUCCESS"
        };
    }

    private ResultType<User> CreateUserException()
    {
        return new ResultType<User>
        {
            Result = null,
            Status = "FAILURE",
            Message = "Name is invalid!"
        };
    }

    [Benchmark]
    public void ResultTypeCreation()
    {
        var newUser = CreateUser();
    }

    [Benchmark]
    public void ResultTypeCreationException()
    {
        var newUser = CreateUserException();
    }

    [Benchmark]
    public void ResultTypeGetUser()
    {
        var result = CreateUser();

        var user = result.Result;
    }
}