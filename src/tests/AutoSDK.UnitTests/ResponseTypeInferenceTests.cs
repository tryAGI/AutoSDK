using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.UnitTests;

[TestClass]
public class ResponseTypeInferenceTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "Api",
    };

    [TestMethod]
    [DataRow("audio/mpeg")]
    [DataRow("audio/*")]
    [DataRow("application/octet-stream")]
    [DataRow("application/zip")]
    public void EmptyBinaryMediaTypeResponse_GeneratesByteArrayReturnType(string mimeType)
    {
        var endPoint = LoadEndPoint($@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /audio:
    get:
      operationId: getAudio
      responses:
        '200':
          description: OK
          content:
            '{mimeType}': {{}}
");

        endPoint.ContentType.Should().Be(ContentType.ByteArray);
        endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("byte[]");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        generatedCode.Should().Contain("Task<byte[]> GetAudioAsync(");
        generatedCode.Should().Contain("ReadAsByteArrayAsync(");
        generatedCode.Should().Contain("return __content;");
    }

    [TestMethod]
    public void ExplicitBinarySchema_UsesByteArrayTransportForUnknownMimeType()
    {
        var endPoint = LoadEndPoint(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /document:
    get:
      operationId: getDocument
      responses:
        '200':
          description: OK
          content:
            'application/pdf':
              schema:
                type: string
                format: binary
");

        endPoint.ContentType.Should().Be(ContentType.ByteArray);
        endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("byte[]");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        generatedCode.Should().Contain("Task<byte[]> GetDocumentAsync(");
        generatedCode.Should().Contain("ReadAsByteArrayAsync(");
        generatedCode.Should().Contain("return __content;");
    }

    [TestMethod]
    public void RealElevenLabsBufferedBinaryResponses_GenerateByteArrayMethods()
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
            MethodNamingConvention = MethodNamingConvention.MethodAndPath,
        };
        var data = AutoSDK.Generation.Data.Prepare(((new H.Resource("elevenlabs.json").AsString(), settings), GlobalSettings: settings));
        var expectedPaths = new[]
        {
            "\"/v1/audio-isolation\"",
            "$\"/v1/voices/{voiceId}/samples/{sampleId}/audio\"",
        };

        foreach (var expectedPath in expectedPaths)
        {
            var endPoint = data.Methods.Single(x => string.Equals(x.Path, expectedPath, StringComparison.Ordinal));

            endPoint.ContentType.Should().Be(ContentType.ByteArray);
            endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("byte[]");

            var generatedCode = Sources.GenerateEndPoint(endPoint);

            generatedCode.Should().Contain("Task<byte[]>");
            generatedCode.Should().Contain("ReadAsByteArrayAsync(");
            generatedCode.Should().Contain("return __content;");
        }
    }

    [TestMethod]
    public void RealElevenLabsFernBinaryStreamingResponses_GenerateStreamMethods()
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
            MethodNamingConvention = MethodNamingConvention.MethodAndPath,
        };
        var data = AutoSDK.Generation.Data.Prepare(((new H.Resource("elevenlabs.json").AsString(), settings), GlobalSettings: settings));
        var expectedPaths = new[]
        {
            "\"/v1/audio-isolation/stream\"",
            "$\"/v1/convai/conversations/{conversationId}/audio\"",
            "$\"/v1/text-to-speech/{voiceId}/stream\"",
            "$\"/v1/speech-to-speech/{voiceId}/stream\"",
            "$\"/v1/studio/projects/{projectId}/snapshots/{projectSnapshotId}/stream\"",
            "$\"/v1/studio/projects/{projectId}/chapters/{chapterId}/snapshots/{chapterSnapshotId}/stream\"",
        };

        foreach (var expectedPath in expectedPaths)
        {
            var endPoint = data.Methods.Single(x => string.Equals(x.Path, expectedPath, StringComparison.Ordinal));

            endPoint.RawStream.Should().BeTrue($"Path={endPoint.Path}, StreamFormat={endPoint.StreamFormat}, ContentType={endPoint.ContentType}, ReturnType={endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}");
            endPoint.ContentType.Should().Be(ContentType.Stream);
            endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("global::System.IO.Stream");

            var generatedCode = Sources.GenerateEndPoint(endPoint);

            generatedCode.Should().Contain("Task<global::System.IO.Stream>");
            generatedCode.Should().Contain("HttpCompletionOption.ResponseHeadersRead");
            generatedCode.Should().Contain("return new global::G.ResponseStream(__response, __content);");
            generatedCode.Should().NotContain("using var __response = await HttpClient.SendAsync(");
            generatedCode.Should().NotContain("ReadAsByteArrayAsync(");
        }
    }

    [TestMethod]
    public void RealElevenLabsFernJsonStreamingResponses_GenerateAsyncEnumerableMethods()
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
            MethodNamingConvention = MethodNamingConvention.MethodAndPath,
        };
        var data = AutoSDK.Generation.Data.Prepare(((new H.Resource("elevenlabs.json").AsString(), settings), GlobalSettings: settings));
        var expectedPaths = new[]
        {
            "$\"/v1/text-to-speech/{voiceId}/stream/with-timestamps\"",
            "\"/v1/text-to-dialogue/stream/with-timestamps\"",
        };

        foreach (var expectedPath in expectedPaths)
        {
            var endPoint = data.Methods.Single(x => string.Equals(x.Path, expectedPath, StringComparison.Ordinal));

            endPoint.EnumerableStream.Should().BeTrue();
            endPoint.ContentType.Should().Be(ContentType.String);
            endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().NotBe("string");

            var generatedCode = Sources.GenerateEndPoint(endPoint);

            generatedCode.Should().Contain("IAsyncEnumerable<");
            generatedCode.Should().Contain("HttpCompletionOption.ResponseHeadersRead");
            generatedCode.Should().Contain("ReadLineAsync()");
            generatedCode.Should().Contain("yield return __streamedResponse;");
            generatedCode.Should().NotContain("Task<byte[]>");
        }
    }

    private static EndPoint LoadEndPoint(string yaml)
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var operations = data.Methods;

        return operations.Single();
    }
}
