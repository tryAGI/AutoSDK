using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using BenchmarkDotNet.Attributes;

namespace AutoSDK.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 5)]
public class DataPrepareBenchmarks
{
    private string _openaiYaml = null!;
    private string _elevenlabsJson = null!;
    private string _cohereYaml = null!;
    private string _assemblyaiYaml = null!;
    private string _vectaraYaml = null!;
    private string _petstoreYaml = null!;
    private Settings _settings;

    [GlobalSetup]
    public void Setup()
    {
        _openaiYaml = new H.Resource("openai.yaml").AsString();
        _elevenlabsJson = new H.Resource("elevenlabs.json").AsString();
        _cohereYaml = new H.Resource("cohere.yaml").AsString();
        _assemblyaiYaml = new H.Resource("assemblyai.yaml").AsString();
        _vectaraYaml = new H.Resource("vectara.yaml").AsString();
        _petstoreYaml = new H.Resource("petstore.yaml").AsString();

        _settings = Settings.Default with
        {
            TargetFramework = "net8.0",
            Namespace = "G",
            ClassName = "Api",
            ClsCompliantEnumPrefix = "x",
            GenerateSdk = true,
            GenerateModels = true,
            GenerateMethods = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
        };
    }

    [Benchmark]
    public Models.Data Petstore() =>
        AutoSDK.Generation.Data.Prepare(((_petstoreYaml, _settings), GlobalSettings: _settings));

    [Benchmark]
    public Models.Data AssemblyAI() =>
        AutoSDK.Generation.Data.Prepare(((_assemblyaiYaml, _settings), GlobalSettings: _settings));

    [Benchmark]
    public Models.Data Cohere() =>
        AutoSDK.Generation.Data.Prepare(((_cohereYaml, _settings), GlobalSettings: _settings));

    [Benchmark]
    public Models.Data Vectara() =>
        AutoSDK.Generation.Data.Prepare(((_vectaraYaml, _settings), GlobalSettings: _settings));

    [Benchmark]
    public Models.Data OpenAI() =>
        AutoSDK.Generation.Data.Prepare(((_openaiYaml, _settings), GlobalSettings: _settings));

    [Benchmark]
    public Models.Data ElevenLabs() =>
        AutoSDK.Generation.Data.Prepare(((_elevenlabsJson, _settings), GlobalSettings: _settings));
}
