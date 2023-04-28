// See https://aka.ms/new-console-template for more information

using Alza.ResultTypes.Benchmarks;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<OneOfBenchmark>();
//var summary = BenchmarkRunner.Run<OneOfBenchmark>();
//var summary = BenchmarkRunner.Run<OneOfBenchmark>();
