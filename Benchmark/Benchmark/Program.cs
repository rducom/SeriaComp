using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CompressionBenchmark>();
        }
    }

    public class CompressionBenchmark
    {
        [Benchmark]
        public void MessagePack()
        {

        }

        [Benchmark]
        public void Zero() 

        {

        }
    }
}
