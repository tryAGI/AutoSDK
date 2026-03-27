using AutoSDK.Generation;
using AutoSDK.Models;
using BenchmarkDotNet.Attributes;

namespace AutoSDK.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 5)]
public class DataPrepareBenchmarks
{
    private readonly BenchmarkFixture _fixture = new();

    [GlobalSetup]
    public void Setup()
    {
        _fixture.Setup();
    }

    [Benchmark]
    public CorePipelineResult GitHub_CorePrepare() => _fixture.PrepareCore("GitHub");

    [Benchmark]
    public Models.Data GitHub_PrepareAndEnrich() => _fixture.PrepareAndEnrich("GitHub");

    [Benchmark]
    public int GitHub_PrepareEnrichAndGenerateFiles() =>
        _fixture.PrepareEnrichAndGenerateFiles("GitHub").Count;

    [Benchmark]
    public CorePipelineResult ElevenLabs_CorePrepare() => _fixture.PrepareCore("ElevenLabs");

    [Benchmark]
    public Models.Data ElevenLabs_PrepareAndEnrich() => _fixture.PrepareAndEnrich("ElevenLabs");

    [Benchmark]
    public int ElevenLabs_PrepareEnrichAndGenerateFiles() =>
        _fixture.PrepareEnrichAndGenerateFiles("ElevenLabs").Count;
}
