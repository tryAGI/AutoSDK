using System.Collections.Immutable;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public class CacheTests
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
        GroupByTags: false,
        GenerateMethods: false,
        MethodNamingConvention: default,
        MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
        GenerateMethodsAsHttpClientExtensions: false,
        GenerateMethodsUsingSystemNetHttpJson: false,
        IncludeOperationIds: ImmutableArray.Create(["123", "456"]),
        ExcludeOperationIds: [],
        IncludeTags: [],
        ExcludeTags: [],
        JsonSerializerContext: string.Empty,
        GenerateJsonSerializerContextTypes: false,
        GenerateModels: false,
        ModelStyle: default,
        IncludeModels: ImmutableArray.Create(["123", "456"]),
        ExcludeModels: [],
        GeneratePolyfills: true,
        GenerateSdk: true,
        FromCli: false
    );
    
    // [TestMethod]
    // public void SettingShouldBeEqual()
    // {
    //     var settings1 = DefaultSettings;
    //     var settings2 = DefaultSettings;
    //     
    //     settings1.Should().Be(settings2);
    // }
}