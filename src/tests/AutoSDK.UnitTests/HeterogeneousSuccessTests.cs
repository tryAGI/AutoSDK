using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class HeterogeneousSuccessTests
{
    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public void MixedSuccess_UsesOneStatusDiscriminatedOperation(JsonSerializerType serializer)
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            ClassName = "Api",
            JsonSerializerType = serializer,
        };
        var data = AutoSDK.Generation.Data.Prepare(((TestSpecCache.GetText("heterogeneous-success.yaml"), settings), settings));
        var method = data.Methods.Should().ContainSingle().Subject;
        method.HasHeterogeneousSuccessResponses.Should().BeTrue();
        method.SuccessResponses.Should().HaveCount(3);
        var source = Sources.GenerateEndPoint(method);
        source.Should().Contain("Task<global::G.Api.StreamOrQueueResult>");
        source.Should().Contain("Stream? Body200");
        source.Should().Contain("global::G.StreamOrQueueResponse? Body202");
        source.Should().Contain("(int)__response.StatusCode == 200");
        source.Should().Contain("(int)__response.StatusCode == 202");
        source.Should().Contain("\"audio/wav\"");
        source.Should().Contain("\"audio/ogg\"");
        source.Should().Contain("Body200?.Dispose();");
        source.Should().Contain("HttpCompletionOption.ResponseHeadersRead");
        source.Should().NotContain("StreamOrQueueResult.FromJson");
    }

    [TestMethod]
    public void EquivalentBinaryStatuses_KeepExistingBinaryAndStreamMethods()
    {
        const string spec = """
            openapi: 3.0.3
            info:
              title: Equivalent
              version: '1'
            paths:
              /binary:
                get:
                  operationId: getBinary
                  responses:
                    '200':
                      description: audio
                      content:
                        audio/wav:
                          schema: { type: string, format: binary }
                        audio/ogg:
                          schema: { type: string, format: binary }
                    '201':
                      description: equivalent binary
                      content:
                        application/octet-stream:
                          schema: { type: string, format: binary }
            """;
        var settings = Settings.Default with { Namespace = "G", ClassName = "Api" };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));
        var method = data.Methods.Should().ContainSingle().Subject;
        method.HasHeterogeneousSuccessResponses.Should().BeFalse();
        var source = Sources.GenerateEndPoint(method);
        source.Should().Contain("Task<byte[]> GetBinaryAsync(");
        source.Should().Contain("Task<global::System.IO.Stream> GetBinaryAsStreamAsync(");
    }
}
