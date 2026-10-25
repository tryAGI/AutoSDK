using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task HeterogeneousSuccess(JsonSerializerType serializer)
    {
        var resource = new H.Resource("heterogeneous-success.yaml");
        return CheckSourceAsync<SdkGenerator>(
            jsonSerializerType: serializer,
            additionalTexts: [new CustomAdditionalText(resource.FileName, resource.AsString())],
            callerName: "heterogeneous-success");
    }
}
