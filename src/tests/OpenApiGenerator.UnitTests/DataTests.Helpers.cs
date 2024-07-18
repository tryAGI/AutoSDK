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
        ClsCompliantEnumPrefix: "x",
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
        GeneratePolyfills: true,
        GenerateSdk: true,
        FromCli: false
    );

    private Task VerifyAsync(
        Data data,
        [CallerMemberName] string? callerName = null)
    {
        var modelsTask =
            Verify(data.Models
                    .Select(x => x with { Parents = [] })
                    .ToArray())
                .UseDirectory($"Snapshots/{callerName}/Models")
                .UseFileName("_");
        var methodsTask =
            Verify(data.Methods)
                .UseDirectory($"Snapshots/{callerName}/Methods")
                .UseFileName("_");
        var anyOfsTask =
            Verify(data.AnyOfs)
                .UseDirectory($"Snapshots/{callerName}/AnyOfs")
                .UseFileName("_");
        var typesTask =
            Verify(data.Types)
                .UseDirectory($"Snapshots/{callerName}/Types")
                .UseFileName("_");
        var schemasTask =
            Verify(data.Schemas.Select(x => $"{GetMargin(x)}{x.Id}({x.Type})"))
                .UseDirectory($"Snapshots/{callerName}/Schemas")
                .UseFileName("_");
        
        // modelsTask = modelsTask.AutoVerify();
        // methodsTask = methodsTask.AutoVerify();
        // anyOfsTask = anyOfsTask.AutoVerify();
        // typesTask = typesTask.AutoVerify();
        // schemasTask = schemasTask.AutoVerify();
        
        return Task.WhenAll(modelsTask, methodsTask, anyOfsTask, typesTask, schemasTask);
    }

    private static string GetMargin(SchemaContext context)
    {
        var margin = string.Empty;

        while (context.Parent != null)
        {
            margin += "  ";
            context = context.Parent;
        }
        
        return margin;
    }
}