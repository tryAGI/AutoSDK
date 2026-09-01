using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class MediaTypeCapabilityTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net10.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateMethods = true,
        GenerateModels = true,
        GenerateSdk = true,
        GenerateJsonSerializerContextTypes = true,
    };

    [TestMethod]
    public void BinarySchemaCache_HandlesCyclesWithoutBinaryValues()
    {
        var first = new OpenApiSchema { Type = JsonSchemaType.Object };
        var second = new OpenApiSchema { Type = JsonSchemaType.Object };
        first.Properties = new Dictionary<string, IOpenApiSchema> { ["second"] = second };
        second.Properties = new Dictionary<string, IOpenApiSchema> { ["first"] = first };
        var cache = new RequestRepresentationPlanner.BinarySchemaCache();

        cache.ContainsBinary(first).Should().BeFalse();
        cache.ContainsBinary(second).Should().BeFalse();
    }

    [TestMethod]
    public void BinarySchemaCache_PropagatesBinaryValuesAcrossCycles()
    {
        var first = new OpenApiSchema { Type = JsonSchemaType.Object };
        var second = new OpenApiSchema { Type = JsonSchemaType.Object };
        var binary = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" };
        first.Properties = new Dictionary<string, IOpenApiSchema>
        {
            ["second"] = second,
            ["content"] = binary,
        };
        second.Properties = new Dictionary<string, IOpenApiSchema> { ["first"] = first };
        var cache = new RequestRepresentationPlanner.BinarySchemaCache();

        cache.ContainsBinary(first).Should().BeTrue();
        cache.ContainsBinary(second).Should().BeTrue();
    }

    [TestMethod]
    public void CapabilityMatrix_CoversTypedRawStreamingAndUnsupportedStates()
    {
        MediaTypeCapabilities.GetRequestSupport("application/json")
            .Should().Be(MediaTypeTransportSupport.Typed);
        MediaTypeCapabilities.GetRequestSupport("application/msgpack")
            .Should().Be(MediaTypeTransportSupport.Raw);
        MediaTypeCapabilities.GetRequestSupport("text/event-stream")
            .Should().Be(MediaTypeTransportSupport.Unsupported);
        MediaTypeCapabilities.GetResponseSupport("application/x-ndjson")
            .Should().Be(MediaTypeTransportSupport.Streaming);
        MediaTypeCapabilities.GetResponseSupport("multipart/form-data")
            .Should().Be(MediaTypeTransportSupport.Unsupported);
    }

    [TestMethod]
    public void MimeTypeComparison_NormalizesParametersOnBothValues()
    {
        "application/json; charset=utf-8".IsMimeType("application/json; profile=provider")
            .Should().BeTrue();
    }

    [TestMethod]
    public void CapabilityDocumentation_IsGeneratedFromTheCapabilityContract()
    {
        var documentationPath = Path.Combine(
            Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../../../..")),
            "docs",
            "media-type-capabilities.md");

        File.ReadAllText(documentationPath).ReplaceLineEndings("\n")
            .Should().Be(MediaTypeCapabilities.GenerateMarkdown());
    }

    [TestMethod]
    public void TypedMessagePackWithJsonAlternative_SelectsSupportedJsonRepresentation()
    {
        var data = AutoSDK.Generation.Data.Prepare(((CreateRequestSpec("""
          application/msgpack:
            schema:
              type: object
              properties:
                prompt:
                  type: string
          application/json:
            schema:
              type: object
              properties:
                prompt:
                  type: string
"""), DefaultSettings), GlobalSettings: DefaultSettings));

        data.Methods.Should().ContainSingle()
            .Which.RequestMediaType.Should().Be("application/json");
    }

    [TestMethod]
    public void JsonAndBinaryRequests_GenerateTypedAndRawCompanionMethods()
    {
        var data = AutoSDK.Generation.Data.Prepare(((CreateRequestSpec("""
          application/json:
            schema:
              type: object
              required: [url]
              properties:
                url:
                  type: string
          application/octet-stream:
            schema:
              type: string
              format: binary
"""), DefaultSettings), GlobalSettings: DefaultSettings));

        data.Methods.Select(static method => method.NotAsyncMethodName)
            .Should().BeEquivalentTo("Run", "RunWithBytes");

        var json = data.Methods.Single(static method => method.NotAsyncMethodName == "Run");
        json.RequestMediaType.Should().Be("application/json");
        json.Parameters.Should().Contain(parameter => parameter.ParameterName == "url");

        var binary = data.Methods.Single(static method => method.NotAsyncMethodName == "RunWithBytes");
        binary.RequestMediaType.Should().Be("application/octet-stream");
        binary.RequestType.CSharpTypeWithoutNullability.Should().Be("byte[]");
        Sources.GenerateEndPoint(binary)
            .Should().Contain("new global::System.Net.Http.ByteArrayContent(request)");
    }

    [TestMethod]
    public void JsonAndMultipartRequests_KeepSingleTypedRepresentation()
    {
        var data = AutoSDK.Generation.Data.Prepare(((CreateRequestSpec("""
          application/json:
            schema:
              type: object
              properties:
                prompt:
                  type: string
          multipart/form-data:
            schema:
              type: object
              properties:
                prompt:
                  type: string
"""), DefaultSettings), GlobalSettings: DefaultSettings));

        data.Methods.Should().ContainSingle()
            .Which.RequestMediaType.Should().Be("application/json");
    }

    [TestMethod]
    public void TypedMessagePackWithoutAlternative_GeneratesRawBytePassThrough()
    {
        var data = AutoSDK.Generation.Data.Prepare(((CreateRequestSpec("""
          application/msgpack:
            schema:
              type: object
              properties:
                prompt:
                  type: string
"""), DefaultSettings), GlobalSettings: DefaultSettings));
        var method = data.Methods.Should().ContainSingle().Subject;
        var source = Sources.GenerateEndPoint(method);

        method.RequestMediaType.Should().Be("application/msgpack");
        method.RequestType.CSharpTypeWithoutNullability.Should().Be("byte[]");
        source.Should().Contain("new global::System.Net.Http.ByteArrayContent(request)");
        source.Should().Contain("MediaTypeHeaderValue(\"application/msgpack\")");
        source.Should().NotContain("JsonSerializer.Serialize(request");
    }

    [TestMethod]
    public void RawMessagePackBinary_PreservesMediaTypeWithoutJsonSerialization()
    {
        var data = AutoSDK.Generation.Data.Prepare(((CreateRequestSpec("""
          application/msgpack:
            schema:
              type: string
              format: binary
"""), DefaultSettings), GlobalSettings: DefaultSettings));
        var method = data.Methods.Should().ContainSingle().Subject;
        var source = Sources.GenerateEndPoint(method);

        method.RequestMediaType.Should().Be("application/msgpack");
        source.Should().Contain("new global::System.Net.Http.ByteArrayContent(request)");
        source.Should().Contain("MediaTypeHeaderValue(\"application/msgpack\")");
        source.Should().NotContain("JsonSerializer.Serialize(request");
    }

    [TestMethod]
    public void ProviderSpecificString_UsesRawTextWithoutJsonSerialization()
    {
        var data = AutoSDK.Generation.Data.Prepare(((CreateRequestSpec("""
          application/sdp:
            schema:
              type: string
"""), DefaultSettings), GlobalSettings: DefaultSettings));
        var method = data.Methods.Should().ContainSingle().Subject;
        var source = Sources.GenerateEndPoint(method);

        method.RequestMediaType.Should().Be("application/sdp");
        source.Should().Contain("new global::System.Net.Http.StringContent(");
        source.Should().Contain("mediaType: \"application/sdp\"");
        source.Should().NotContain("JsonSerializer.Serialize(request");
    }

    [TestMethod]
    public void FormUrlEncodedRequest_UsesFormEncoderAndOnlyBodyFields()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Form
  version: 1.0.0
paths:
  /tokens/{tenant}:
    post:
      operationId: createToken
      parameters:
        - name: tenant
          in: path
          required: true
          schema:
            type: string
        - name: X-Trace
          in: header
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/x-www-form-urlencoded:
            schema:
              type: object
              required: [grant_type]
              properties:
                grant_type:
                  type: string
                scope:
                  type: array
                  items:
                    type: string
      responses:
        '204':
          description: ok
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var source = Sources.GenerateEndPoint(data.Methods.Should().ContainSingle().Subject);

        source.Should().Contain("new global::System.Net.Http.FormUrlEncodedContent(__formValues)");
        source.Should().Contain("\"grant_type\"");
        source.Should().Contain("\"scope\"");
        source.Should().NotContain("new global::System.Collections.Generic.KeyValuePair<string, string>(\n                \"tenant\"");
        source.Should().NotContain("new global::System.Collections.Generic.KeyValuePair<string, string>(\n                \"X-Trace\"");
    }

    [TestMethod]
    public void JsonBinaryAndTextResponses_GenerateNegotiatedShapeVariants()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Responses
  version: 1.0.0
paths:
  /reports/{id}:
    get:
      operationId: getReport
      parameters:
        - name: id
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: object
                properties:
                  id:
                    type: string
            image/png:
              schema:
                type: string
                format: binary
            text/csv:
              schema:
                type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));

        data.Methods.Select(static method => method.NotAsyncMethodName)
            .Should().BeEquivalentTo("GetReport", "GetReportAsBytes", "GetReportAsText");
        AssertAccept(data.Methods.Single(static method => method.NotAsyncMethodName == "GetReport"), "application/json");
        AssertAccept(data.Methods.Single(static method => method.NotAsyncMethodName == "GetReportAsBytes"), "image/png");
        AssertAccept(data.Methods.Single(static method => method.NotAsyncMethodName == "GetReportAsText"), "text/csv");
        data.Methods.Single(static method => method.NotAsyncMethodName == "GetReportAsBytes")
            .SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("byte[]");
        data.Methods.Single(static method => method.NotAsyncMethodName == "GetReportAsText")
            .SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Be("string");
    }

    [TestMethod]
    public void EquivalentVendorJsonResponses_DoNotDuplicateMethods()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Responses
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Item'
            application/vnd.example+json:
              schema:
                $ref: '#/components/schemas/Item'
components:
  schemas:
    Item:
      type: object
      properties:
        id:
          type: string
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));

        data.Methods.Should().ContainSingle()
            .Which.SuccessResponse.MimeType.Should().Be("application/json");
    }

    [TestMethod]
    public void RepresentationAudit_FlagsFishAudioRiskAndDistinctCounterexample()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Audit
  version: 1.0.0
paths:
  /fish:
    post:
      operationId: fishUpload
      requestBody:
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Upload'
          multipart/form-data:
            schema:
              $ref: '#/components/schemas/Upload'
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: object
            image/png:
              schema:
                type: string
                format: binary
  /distinct:
    post:
      operationId: distinctUpload
      requestBody:
        content:
          application/json:
            schema:
              type: object
              properties:
                url:
                  type: string
          multipart/form-data:
            schema:
              type: object
              properties:
                file:
                  type: string
                  format: binary
      responses:
        '204':
          description: ok
components:
  schemas:
    Upload:
      type: object
      properties:
        file:
          anyOf:
            - type: string
              format: binary
            - type: array
              items:
                type: string
                format: binary
""";
        var document = yaml.GetOpenApiDocument(DefaultSettings);
        var schemas = document.GetSchemas(DefaultSettings);
        var operations = document.GetOperations(DefaultSettings, DefaultSettings, schemas);

        var findings = RepresentationRiskAuditor.Audit("fixture.yaml", operations);

        findings.Should().Contain(finding =>
            finding.OperationId == "fishUpload" &&
            finding.Code == "binary-prefers-multipart" &&
            finding.SelectedMediaType == "multipart/form-data");
        findings.Should().Contain(finding =>
            finding.OperationId == "fishUpload" &&
            finding.Code == "equivalent-request-shapes");
        findings.Should().Contain(finding =>
            finding.OperationId == "fishUpload" &&
            finding.Code == "multiple-success-media-types");
        findings.Should().Contain(finding =>
            finding.OperationId == "distinctUpload" &&
            finding.Code == "distinct-request-shapes");
    }

    private static string CreateRequestSpec(string content)
    {
        return $$"""
openapi: 3.0.3
info:
  title: Requests
  version: 1.0.0
paths:
  /run:
    post:
      operationId: run
      requestBody:
        required: true
        content:
{{content}}
      responses:
        '204':
          description: ok
""";
    }

    private static void AssertAccept(EndPoint endPoint, string mediaType)
    {
        Sources.GenerateEndPoint(endPoint).Should().Contain($"\"Accept\",\n                    \"{mediaType}\"");
    }
}
