using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class CacheTests
{
    private Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
        IncludeOperationIds = ["123", "456"],
        IncludeModels = ["123", "456"],
    };
    
    // [TestMethod]
    // public void SettingShouldBeEqual()
    // {
    //     var settings1 = DefaultSettings;
    //     var settings2 = DefaultSettings;
    //     
    //     settings1.Should().Be(settings2);
    // }
}