using BenchmarkDotNet.Attributes;

namespace ConsolePlayon;
public class PersonBenchmark
{
    private readonly List<int> _numbers = Enumerable.Range(1, 100).ToList();

    [Benchmark]
    public int CalculateUsingImperativeAndFor()
    {
        var sum = 0;

        for (int i = 0; i < _numbers.Count; i++)
        {
            sum += _numbers[i];
        }

        return sum;
    }

    [Benchmark]
    public int CalculateUsingImperativeAndForEach()
    {
        var sum = 0;

        foreach (var num in _numbers)
        {
            sum += num;
        }

        return sum;
    }

    [Benchmark]
    public int CalculateUsingFp() => _numbers.Sum();
}
