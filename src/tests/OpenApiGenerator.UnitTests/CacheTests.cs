using System.Collections.Immutable;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public class CacheTests
{
    private Settings DefaultSettings => new(
        TargetFramework: "netstandard2.0",
        Namespace: "G",
        ClassName: "Api",
        NamingConvention: default,
        JsonSerializerType: default,
        UseRequiredKeyword: default,
        GenerateConstructors: true,
        GenerateMethods: true,
        IncludeOperationIds: ImmutableArray.Create(["123", "456"]),
        GenerateModels: false,
        ModelStyle: default,
        IncludeModels: ImmutableArray.Create(["123", "456"])
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