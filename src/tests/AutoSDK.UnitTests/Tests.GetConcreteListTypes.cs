using AutoSDK.Generation;

namespace AutoSDK.UnitTests;

[TestClass]
public class GetConcreteListTypesTests
{
    [TestMethod]
    public void EmptyInput_ReturnsEmpty()
    {
        var result = Sources.GetConcreteListTypes([]);

        result.Should().BeEmpty();
    }

    [TestMethod]
    public void NoIListTypes_ReturnsEmpty()
    {
        var result = Sources.GetConcreteListTypes(["string", "int", "global::MyNamespace.MyClass"]);

        result.Should().BeEmpty();
    }

    [TestMethod]
    public void IListType_ReturnsListCounterpart()
    {
        var result = Sources.GetConcreteListTypes(
            ["global::System.Collections.Generic.IList<global::MyNamespace.Item>"]);

        result.Should().ContainSingle()
            .Which.Should().Be("global::System.Collections.Generic.List<global::MyNamespace.Item>");
    }

    [TestMethod]
    public void IListType_AlreadyHasListCounterpart_ExcludesDuplicate()
    {
        var result = Sources.GetConcreteListTypes(
        [
            "global::System.Collections.Generic.IList<global::MyNamespace.Item>",
            "global::System.Collections.Generic.List<global::MyNamespace.Item>",
        ]);

        result.Should().BeEmpty();
    }

    [TestMethod]
    public void MultipleIListTypes_ReturnsAllCounterparts()
    {
        var result = Sources.GetConcreteListTypes(
        [
            "global::System.Collections.Generic.IList<string>",
            "global::System.Collections.Generic.IList<int>",
        ]);

        result.Should().HaveCount(2);
        result.Should().Contain("global::System.Collections.Generic.List<string>");
        result.Should().Contain("global::System.Collections.Generic.List<int>");
    }

    [TestMethod]
    public void MixedTypes_OnlyConvertsIListTypes()
    {
        var result = Sources.GetConcreteListTypes(
        [
            "string",
            "global::System.Collections.Generic.IList<global::MyNamespace.Item>",
            "global::MyNamespace.MyClass",
        ]);

        result.Should().ContainSingle()
            .Which.Should().Be("global::System.Collections.Generic.List<global::MyNamespace.Item>");
    }

    [TestMethod]
    public void NestedIListType_ReplacesAllLevels()
    {
        var result = Sources.GetConcreteListTypes(
            ["global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>"]);

        result.Should().ContainSingle()
            .Which.Should().Be("global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>");
    }
}
