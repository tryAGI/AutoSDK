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
        ["ElevenLabsCurrent"] = string.Empty,
        ["VapiCurrent"] = string.Empty,
        ["AnthropicCurrent"] = string.Empty,
        ["OpenAICurrent"] = string.Empty,
    };

    public Settings Settings { get; private set; }

    public IEnumerable<string> LargeSpecs => _specs.Keys;

    public void Setup()
    {
        _specs["GitHub"] = new H.Resource("github.yaml").AsString();
        _specs["ElevenLabs"] = new H.Resource("elevenlabs.json").AsString();
        _specs["ElevenLabsCurrent"] = new H.Resource("elevenlabs-current.json").AsString();
        _specs["VapiCurrent"] = new H.Resource("vapi-current.yaml").AsString();
        _specs["AnthropicCurrent"] = new H.Resource("anthropic-current.yaml").AsString();
        _specs["OpenAICurrent"] = new H.Resource("openai-current.yaml").AsString();

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
        return PrepareCore(specName, CSharpPipeline.ApplyModelNaming);
    }

    public CorePipelineResult PrepareCore(
        string specName,
        Action<IReadOnlyList<SchemaContext>> applyNaming)
    {
        return CorePipeline.Prepare(
            ((GetSpecText(specName), Settings), GlobalSettings: Settings),
            static (document, settings) => document.GetSchemas((CSharpSettings)settings),
            applyNaming,
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
