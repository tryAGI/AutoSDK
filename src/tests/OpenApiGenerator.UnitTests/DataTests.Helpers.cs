using System.Runtime.CompilerServices;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public partial class DataTests : VerifyBase
{
    private Settings DefaultSettings => new(
        TargetFramework: "netstandard2.0",
        Namespace: "G",
        ClassName: "Api",
        NamingConvention: default,
        JsonSerializerType: default,
        UseRequiredKeyword: default,
        GenerateConstructors: false,
        GroupByTags: true,
        GenerateMethods: false,
        MethodNamingConvention: default,
        MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
        GenerateMethodsAsHttpClientExtensions: false,
        GenerateMethodsUsingSystemNetHttpJson: false,
        IncludeOperationIds: [],
        ExcludeOperationIds: [],
        IncludeTags: [],
        ExcludeTags: [],
        JsonSerializerContext: string.Empty,
        GenerateJsonSerializerContextTypes: false,
        GenerateModels: false,
        ModelStyle: default,
        IncludeModels: [],
        ExcludeModels: [],
        GenerateSdk: true,
        FromCli: false
    );

    private Task VerifyAsync(
        (EquatableArray<ModelData> Models, EquatableArray<EndPoint> Methods, EquatableArray<AnyOfData> AnyOfs, EquatableArray<TypeData> Types, EndPoint Converters) tuple,
        [CallerMemberName] string? callerName = null)
    {
        var modelsTask =
            Verify(tuple.Models
                    .Select(x => x with { Parents = [] })
                    .ToArray())
                .UseDirectory($"Snapshots/{callerName}/Models")
                .UseFileName("_");
        var methodsTask =
            Verify(tuple.Methods)
                .UseDirectory($"Snapshots/{callerName}/Methods")
                .UseFileName("_");
        var anyOfsTask =
            Verify(tuple.AnyOfs)
                .UseDirectory($"Snapshots/{callerName}/AnyOfs")
                .UseFileName("_");
        var typesTask =
            Verify(tuple.Types)
                .UseDirectory($"Snapshots/{callerName}/Types")
                .UseFileName("_");
        
        // modelsTask = modelsTask.AutoVerify();
        // methodsTask = methodsTask.AutoVerify();
        // anyOfsTask = anyOfsTask.AutoVerify();
        // typesTask = typesTask.AutoVerify();
        
        return Task.WhenAll(modelsTask, methodsTask, anyOfsTask, typesTask);
    }
}