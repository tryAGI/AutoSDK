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
            generatedCode.Should().Contain("String.IsNullOrWhiteSpace(__content)");
            generatedCode.Should().Contain("continue;");
            generatedCode.Should().Contain("yield return __streamedResponse;");
            generatedCode.Should().NotContain("Task<byte[]>");
        }
    }

    [TestMethod]
    public void RealCohereFernStreamingMetadata_SplitsChatIntoRegularAndNdjsonStreamMethods()
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
        };
        var data = LoadDataFromResource("cohere.yaml", settings);
        var chatEndPoints = data.Methods
            .Where(x => string.Equals(x.Path, "\"/v1/chat\"", StringComparison.Ordinal))
            .ToArray();

        chatEndPoints.Should().HaveCount(2);
        chatEndPoints.Select(x => x.ForcedRequestStreamValue).Should().BeEquivalentTo([false, true]);

        var regularEndPoint = chatEndPoints.Single(x => x.ForcedRequestStreamValue == false);
        var streamEndPoint = chatEndPoints.Single(x => x.ForcedRequestStreamValue == true);
        regularEndPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("global::G.NonStreamedChatResponse");
        streamEndPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("global::G.StreamedChatResponse");

        regularEndPoint.StreamFormat.Should().Be(StreamFormat.None);
        var regularCode = Sources.GenerateEndPoint(regularEndPoint);
        regularCode.Should().Contain("Task<global::G.NonStreamedChatResponse> ChatAsync(");
        regularCode.Should().NotContain("Task<global::G.OneOf<");

        streamEndPoint.StreamFormat.Should().Be(StreamFormat.Ndjson);
        var streamCode = Sources.GenerateEndPoint(streamEndPoint);
        streamCode.Should().Contain("IAsyncEnumerable<global::G.StreamedChatResponse> ChatAsStreamAsync(");
        streamCode.Should().Contain("ReadLineAsync()");
        streamCode.Should().NotContain("Task<global::G.OneOf<");
    }

    [TestMethod]
    public void RealCohereFernStreamingMetadata_SplitsChatV2IntoRegularAndSseStreamMethods()
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
        };
        var data = LoadDataFromResource("cohere.yaml", settings);
        var chatEndPoints = data.Methods
            .Where(x => string.Equals(x.Path, "\"/v2/chat\"", StringComparison.Ordinal))
            .ToArray();

        chatEndPoints.Should().HaveCount(2);
        chatEndPoints.Select(x => x.ForcedRequestStreamValue).Should().BeEquivalentTo([false, true]);

        var regularEndPoint = chatEndPoints.Single(x => x.ForcedRequestStreamValue == false);
        var streamEndPoint = chatEndPoints.Single(x => x.ForcedRequestStreamValue == true);
        regularEndPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("global::G.ChatResponse");
        streamEndPoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("global::G.StreamedChatResponseV2");

        regularEndPoint.StreamFormat.Should().Be(StreamFormat.None);
        var regularCode = Sources.GenerateEndPoint(regularEndPoint);
        regularCode.Should().Contain("Task<global::G.ChatResponse> Chat2Async(");
        regularCode.Should().NotContain("Task<global::G.OneOf<");

        streamEndPoint.StreamFormat.Should().Be(StreamFormat.ServerSentEvents);
        var streamCode = Sources.GenerateEndPoint(streamEndPoint);
        streamCode.Should().Contain("IAsyncEnumerable<global::G.StreamedChatResponseV2> Chat2AsStreamAsync(");
        streamCode.Should().Contain("SseParser");
        streamCode.Should().NotContain("Task<global::G.OneOf<");
    }

    [TestMethod]
    public void FernStreamingMetadata_WithCustomSseTerminator_UsesConfiguredTerminator()
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /events:
    post:
      operationId: streamEvents
      x-fern-streaming:
        format: sse
        terminator: ""[COMPLETE]""
      responses:
        '200':
          description: OK
          content:
            text/event-stream:
              schema:
                type: object
                properties:
                  delta:
                    type: string
", settings), GlobalSettings: settings));
        var streamEndPoint = data.Methods.Single();

        streamEndPoint.StreamFormat.Should().Be(StreamFormat.ServerSentEvents);
        var generatedCode = Sources.GenerateEndPoint(streamEndPoint);

        generatedCode.Should().Contain("__content == \"[COMPLETE]\"");
    }

    [TestMethod]
    public void ErrorResponse_StreamPath_PopulatesResponseBody()
    {
        var endPoint = LoadEndPoint(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: array
                items:
                  type: string
        '400':
          description: Bad Request
          content:
            application/json:
              schema:
                type: object
                properties:
                  error:
                    type: string
");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // Error handler else (stream) branch should read as string, not stream
        generatedCode.Should().Contain("ResponseBody = __content_400");
        // The else branch should use ReadAsStringAsync for error responses
        generatedCode.Should().NotContain("__contentStream_400");
    }

    [TestMethod]
    public void SuccessPath_StreamCatch_PopulatesResponseBody()
    {
        var endPoint = LoadEndPoint(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: array
                items:
                  type: string
");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // The stream catch block should attempt to read response body
        // and populate ResponseBody in ApiException
        generatedCode.Should().Contain("ResponseBody = __content,");
    }

    [TestMethod]
    public void RawStream_Catch_PopulatesResponseBody()
    {
        var endPoint = LoadEndPoint(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /audio:
    get:
      operationId: getAudio
      x-fern-streaming: true
      responses:
        '200':
          description: OK
          content:
            application/octet-stream:
              schema:
                type: string
                format: binary
");

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // RawStream catch block should populate ResponseBody
        generatedCode.Should().Contain("ResponseBody = __content,");
    }

    [TestMethod]
    public void SseStream_Catch_PopulatesResponseBody()
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /events:
    get:
      operationId: streamEvents
      responses:
        '200':
          description: OK
          content:
            text/event-stream:
              schema:
                type: object
                properties:
                  data:
                    type: string
", settings), GlobalSettings: settings));
        var endPoint = data.Methods.Single();

        endPoint.StreamFormat.Should().Be(StreamFormat.ServerSentEvents);

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // SSE catch block should populate ResponseBody
        generatedCode.Should().Contain("ResponseBody = __content,");
    }

    [TestMethod]
    public void NdjsonStream_Catch_PopulatesResponseBody()
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /events:
    get:
      operationId: streamEvents
      responses:
        '200':
          description: OK
          content:
            application/x-ndjson:
              schema:
                type: object
                properties:
                  data:
                    type: string
", settings), GlobalSettings: settings));
        var endPoint = data.Methods.Single();

        endPoint.StreamFormat.Should().Be(StreamFormat.Ndjson);

        var generatedCode = Sources.GenerateEndPoint(endPoint);

        // NDJSON catch block should populate ResponseBody
        generatedCode.Should().Contain("ResponseBody = __content,");
    }

    private static EndPoint LoadEndPoint(string yaml)
    {
        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var operations = data.Methods;

        return operations.Single();
    }

    private static AutoSDK.Models.Data LoadDataFromResource(string resourceName, Settings settings)
    {
        return AutoSDK.Generation.Data.Prepare(((new H.Resource(resourceName).AsString(), settings), GlobalSettings: settings));
    }
}
