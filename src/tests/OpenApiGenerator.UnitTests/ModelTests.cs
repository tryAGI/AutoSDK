using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using OpenApiGenerator.Core.Generators;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public class ModelTests :
    VerifyBase
{
    private Settings DefaultSettings => new(
        TargetFramework: "netstandard2.0",
        Namespace: "G",
        ClassName: "Api",
        NamingConvention: default,
        JsonSerializerType: default,
        UseRequiredKeyword: default,
        GenerateConstructors: false,
        GenerateMethods: false,
        MethodNamingConvention: default,
        MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
        GenerateMethodsAsHttpClientExtensions: false,
        GenerateMethodsUsingSystemNetHttpJson: false,
        IncludeOperationIds: [],
        ExcludeOperationIds: [],
        JsonSerializerContext: string.Empty,
        GenerateSuperTypeForJsonSerializerContext: false,
        GenerateModels: false,
        ModelStyle: default,
        IncludeModels: [],
        ExcludeModels: [],
        GenerateSdk: true
    );

    private Task VerifyAsync(
        ImmutableArray<ModelData> models,
        [CallerMemberName] string? callerName = null)
    {
        return Verify(models
                    .Select(x => x with { Parents = [] })
                    .ToArray())
                .UseDirectory($"Snapshots/{callerName}")
                .UseFileName("_")
                //.AutoVerify()
            ;
    }

    [TestMethod]
    public Task OpenAi()
    {
        var yaml = H.Resources.openai_yaml.AsString();
        var settings = DefaultSettings with
        {
            //IncludeModels = ["CreateCompletionResponse"],
        };

        var models = ModelGeneratorMethods.PrepareData((yaml, settings));

        return VerifyAsync(models);
    }

    [TestMethod]
    public Task Ollama()
    {
        var yaml = H.Resources.ollamacurated_yaml.AsString();
        var settings = DefaultSettings;

        var models = ModelGeneratorMethods.PrepareData((yaml, settings));

        return VerifyAsync(models);
    }

    [TestMethod]
    public Task Replicate()
    {
        var models = ModelGeneratorMethods.PrepareData((H.Resources.replicate_json.AsString(), DefaultSettings));

        return VerifyAsync(models);
    }
    
    //
    // [TestMethod]
    // public Task GitHub()
    // {
    //     var yaml = H.Resources.api_github_com_yaml.AsString();
    //     var settings = DefaultSettings;
    //
    //     var models = ModelGeneratorMethods.PrepareData((yaml, settings));
    //
    //     return VerifyAsync(models);
    // }

    [TestMethod]
    public Task LangSmith()
    {
        var yaml = H.Resources.langsmith_yaml.AsString();
        var settings = DefaultSettings with
        {
            //IncludeModels = ["ChatCompletionFunctionParameters"],
        };

        var models = ModelGeneratorMethods.PrepareData((yaml, settings));

        return VerifyAsync(models);
    }
}