using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class OpenRouterObservabilitySnapshotTests : VerifyBase
{
    [TestMethod]
    public Task AnnotationOnlyAllOfMember_PreservesRealOpenRouterResponseType()
    {
        // This fixture is the POST /observability/destinations operation and its
        // referenced schemas from OpenRouter/openapi.yaml, SHA-256
        // 4ad17f46656663662ce3ddac20590367a5a8f1a2e92c1018b24527d08543e364.
        var settings = Settings.Default with { Namespace = "G", ClassName = "Api" };
        var data = AutoSDK.Generation.Data.Prepare(((
            TestSpecCache.GetText("openrouter-observability.json"), settings),
            GlobalSettings: settings));

        data.Classes.Select(x => x.ClassName).Should().NotContain(
            "CreateObservabilityDestinationResponseData");
        var response = data.Classes.Single(x => x.ClassName == "CreateObservabilityDestinationResponse");
        var source = Sources.Class(response).Text;
        source.Should().Contain("global::G.ObservabilityDestination Data");

        return Verify(source)
            .UseDirectory("Snapshots/OpenRouterObservability")
            .UseFileName("CreateObservabilityDestinationResponse");
    }
}
