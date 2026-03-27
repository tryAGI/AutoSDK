using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Benchmarks;

internal sealed class BenchmarkFixture
{
    private readonly Dictionary<string, string> _specs = new(StringComparer.Ordinal)
    {
        ["GitHub"] = string.Empty,
        ["ElevenLabs"] = string.Empty,
    };

    public Settings Settings { get; private set; }

    public IEnumerable<string> LargeSpecs => _specs.Keys;

    public void Setup()
    {
        _specs["GitHub"] = new H.Resource("github.yaml").AsString();
        _specs["ElevenLabs"] = new H.Resource("elevenlabs.json").AsString();

        Settings = Settings.Default with
        {
            TargetFramework = "net8.0",
            Namespace = "G",
            ClassName = "Api",
            ClsCompliantEnumPrefix = "x",
            GenerateSdk = true,
            GenerateModels = true,
            GenerateMethods = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            GenerateJsonSerializerContextTypes = true,
            IgnoreOpenApiErrors = true,
        };
    }

    public CorePipelineResult PrepareCore(string specName)
    {
        return CorePipeline.Prepare(
            ((GetSpecText(specName), Settings), GlobalSettings: Settings),
            static (document, settings) => document.GetSchemas((CSharpSettings)settings),
            CSharpPipeline.ApplyModelNaming,
            static text => text.ToClassName(),
            static text => text.ToPropertyName());
    }

    public Models.Data PrepareAndEnrich(string specName)
    {
        return CSharpPipeline.PrepareAndEnrich(
            ((GetSpecText(specName), Settings), GlobalSettings: Settings));
    }

    public IReadOnlyList<FileWithName> PrepareEnrichAndGenerateFiles(string specName)
    {
        var data = PrepareAndEnrich(specName);
        return CSharpPipeline.GenerateFiles(data);
    }

    private string GetSpecText(string specName)
    {
        return _specs[specName];
    }
}
