using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class ResponseWrapperTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateMethods = true,
        GenerateModels = true,
        GenerateSdk = true,
        GenerateJsonSerializerContextTypes = true,
    };

    [TestMethod]
    public void SuccessResponseHeaders_GenerateAdditiveResponseWrapperMethod()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: ResponseHeaders
  version: 1.0.0
paths:
  /v1/text-to-speech/{voice_id}:
    post:
      operationId: createTextToSpeechByVoiceId
      parameters:
        - in: path
          name: voice_id
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              required: [text]
              properties:
                text:
                  type: string
      responses:
        '200':
          description: Audio bytes
          headers:
            request-id:
              schema:
                type: string
          content:
            audio/mpeg:
              schema:
                type: string
                format: binary
  /health:
    get:
      operationId: getHealth
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));

        var audioMethod = data.Methods.Single(x => x.NotAsyncMethodName == "CreateTextToSpeechByVoiceId");
        var healthMethod = data.Methods.Single(x => x.NotAsyncMethodName == "GetHealth");

        audioMethod.GenerateResponseWrapper.Should().BeTrue();
        healthMethod.GenerateResponseWrapper.Should().BeTrue();

        var methodCode = Sources.GenerateEndPoint(audioMethod);
        var healthMethodCode = Sources.GenerateEndPoint(healthMethod);
        var helperCode = Sources.GenerateHttpResponse((CSharpSettings)audioMethod.Settings);

        methodCode.Should().Contain("public async global::System.Threading.Tasks.Task<byte[]> CreateTextToSpeechByVoiceIdAsync(");
        methodCode.Should().Contain("public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> CreateTextToSpeechByVoiceIdAsResponseAsync(");
        methodCode.Should().Contain("var __response = await CreateTextToSpeechByVoiceIdAsResponseAsync(");
        methodCode.Should().Contain("headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response)");
        methodCode.Should().Contain("requestUri: __response.RequestMessage?.RequestUri");
        helperCode.Should().Contain("public partial class AutoSDKHttpResponse<T> : AutoSDKHttpResponse");
        helperCode.Should().Contain("public global::System.Uri? RequestUri { get; }");
        helperCode.Should().Contain("requestUri: null");
        healthMethodCode.Should().Contain("public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> GetHealthAsResponseAsync(");
        healthMethodCode.Should().Contain("return __response.Body;");
    }

    [TestMethod]
    public void ResponseWrapperExtension_ForcesWrapperGenerationWithoutDeclaredHeaders()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: ForcedResponseWrapper
  version: 1.0.0
paths:
  /models:
    post:
      operationId: createModel
      x-autosdk-response-wrapper: true
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              required: [name]
              properties:
                name:
                  type: string
      responses:
        '201':
          description: created
          content:
            application/json:
              schema:
                type: object
                properties:
                  id:
                    type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var method = data.Methods.Single();
        var methodCode = Sources.GenerateEndPoint(method);

        method.GenerateResponseWrapper.Should().BeTrue();
        methodCode.Should().Contain("CreateModelAsResponseAsync");
        methodCode.Should().Contain("global::G.AutoSDKHttpResponse<global::G.CreateModelResponse>");
    }

    [TestMethod]
    public void ResponseWrapper_GeneratesForEmptyBodyOperations_AndSkipsEnumerableStreams()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: UniversalResponseWrapper
  version: 1.0.0
paths:
  /jobs/{job_id}:
    delete:
      operationId: deleteJob
      parameters:
        - in: path
          name: job_id
          required: true
          schema:
            type: string
      responses:
        '204':
          description: deleted
        '400':
          description: bad request
          content:
            application/json:
              schema:
                type: object
                properties:
                  message:
                    type: string
  /events:
    get:
      operationId: streamEvents
      responses:
        '200':
          description: events
          content:
            text/event-stream:
              schema:
                type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));

        var deleteMethod = data.Methods.Single(x => x.NotAsyncMethodName == "DeleteJob");
        var streamMethod = data.Methods.Single(x => x.NotAsyncMethodName == "StreamEvents");
        var deleteMethodCode = Sources.GenerateEndPoint(deleteMethod);
        var streamMethodCode = Sources.GenerateEndPoint(streamMethod);

        deleteMethod.GenerateResponseWrapper.Should().BeTrue();
        streamMethod.EnumerableStream.Should().BeTrue();
        streamMethod.GenerateResponseWrapper.Should().BeFalse();
        deleteMethodCode.Should().Contain("public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse> DeleteJobAsResponseAsync(");
        deleteMethodCode.Should().Contain("return new global::G.AutoSDKHttpResponse(");
        deleteMethodCode.Should().Contain("requestUri: __response.RequestMessage?.RequestUri");
        streamMethodCode.Should().NotContain("StreamEventsAsResponseAsync");
    }
}
