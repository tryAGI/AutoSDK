using AutoSDK.Extensions;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    [TestMethod]
    public void ExtractEnumSummary_Valid()
    {
        OpenApiExtensions.ExtractEnumSummaryFromDescription(
            id: "VIEW_BASIC",
            description: @"View allows clients to specify the desired resource view in the response.

 - VIEW_BASIC: Default view, only includes basic information.
 - VIEW_FULL: Full representation.").Should().Be("Default view, only includes basic information.");
    }
}