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
    public void RealElevenLabsBinaryResponses_GenerateByteArrayMethods()
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
            "\"/v1/audio-isolation/stream\"",
            "$\"/v1/convai/conversations/{conversationId}/audio\"",
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

    private static EndPoint LoadEndPoint(string yaml)
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var operations = data.Methods;

        return operations.Single();
    }
}
