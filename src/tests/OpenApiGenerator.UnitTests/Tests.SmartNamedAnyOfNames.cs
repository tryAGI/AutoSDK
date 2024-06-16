using OpenApiGenerator.Core.Helpers;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public void SmartNamedAnyOfNames_Valid()
    {
        SmartNamedAnyOfNames.ComputeSmartName(
            typeName: "ChatCompletionRequestMessageContentPartText",
            className: "ChatCompletionRequestMessageContentPart").Should().Be("Text");
    }
}