using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class PrimitiveResponseDeserializationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
    };

    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public void EnumAndPrimitiveResponses_DeserializeWithoutGeneratedModelHelpers(JsonSerializerType jsonSerializerType)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = jsonSerializerType,
            GenerateJsonSerializerContextTypes = jsonSerializerType is JsonSerializerType.SystemTextJson,
        };

        const string yaml = """
openapi: 3.0.3
info:
  title: PrimitiveResponses
  version: 1.0.0
paths:
  /status-inline:
    get:
      operationId: getInlineStatus
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: string
                enum: [queued, running, done]
  /status-ref:
    get:
      operationId: getReferencedStatus
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/JobStatus'
  /status-vendor:
    get:
      operationId: getVendorStatus
      responses:
        '200':
          description: ok
          content:
            application/vnd.cvat+json:
              schema:
                type: string
                enum: [queued, running, done]
  /flag:
    get:
      operationId: getFlag
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: boolean
  /payload:
    get:
      operationId: getPayload
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Payload'
components:
  schemas:
    JobStatus:
      type: string
      enum: [queued, running, done]
    Payload:
      type: object
      properties:
        ok:
          type: boolean
""";

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var inlineEnumMethod = data.Methods.Single(x => x.Path.Contains("/status-inline", StringComparison.Ordinal));
        var referencedEnumMethod = data.Methods.Single(x => x.Path.Contains("/status-ref", StringComparison.Ordinal));
        var vendorEnumMethod = data.Methods.Single(x => x.Path.Contains("/status-vendor", StringComparison.Ordinal));
        var flagMethod = data.Methods.Single(x => x.Path.Contains("/flag", StringComparison.Ordinal));
        var payloadMethod = data.Methods.Single(x => x.Path.Contains("/payload", StringComparison.Ordinal));

        inlineEnumMethod.SuccessResponse.Type.UsesGeneratedJsonHelpers.Should().BeFalse();
        referencedEnumMethod.SuccessResponse.Type.UsesGeneratedJsonHelpers.Should().BeFalse();
        vendorEnumMethod.SuccessResponse.Type.UsesGeneratedJsonHelpers.Should().BeFalse();
        flagMethod.SuccessResponse.Type.UsesGeneratedJsonHelpers.Should().BeFalse();
        payloadMethod.SuccessResponse.Type.UsesGeneratedJsonHelpers.Should().BeTrue();

        var inlineEnumCode = Sources.GenerateEndPoint(inlineEnumMethod);
        var referencedEnumCode = Sources.GenerateEndPoint(referencedEnumMethod);
        var vendorEnumCode = Sources.GenerateEndPoint(vendorEnumMethod);
        var flagCode = Sources.GenerateEndPoint(flagMethod);
        var payloadCode = Sources.GenerateEndPoint(payloadMethod);

        inlineEnumCode.Should().NotContain($"{inlineEnumMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJson(");
        inlineEnumCode.Should().NotContain($"{inlineEnumMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJsonStreamAsync(");
        referencedEnumCode.Should().NotContain($"{referencedEnumMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJson(");
        referencedEnumCode.Should().NotContain($"{referencedEnumMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJsonStreamAsync(");
        vendorEnumCode.Should().NotContain($"{vendorEnumMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJson(");
        vendorEnumCode.Should().NotContain($"{vendorEnumMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJsonStreamAsync(");
        flagCode.Should().NotContain(".FromJson(");
        flagCode.Should().NotContain(".FromJsonStreamAsync(");

        if (jsonSerializerType is JsonSerializerType.SystemTextJson)
        {
            inlineEnumCode.Should().Contain("global::System.Text.Json.JsonSerializer.Deserialize<");
            referencedEnumCode.Should().Contain("global::System.Text.Json.JsonSerializer.Deserialize<");
            vendorEnumCode.Should().Contain("global::System.Text.Json.JsonSerializer.Deserialize<");
            flagCode.Should().Contain("global::System.Text.Json.JsonSerializer.Deserialize<");
            payloadCode.Should().Contain($"{payloadMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJson(");
        }
        else
        {
            inlineEnumCode.Should().Contain("global::Newtonsoft.Json.JsonConvert.DeserializeObject<");
            referencedEnumCode.Should().Contain("global::Newtonsoft.Json.JsonConvert.DeserializeObject<");
            vendorEnumCode.Should().Contain("global::Newtonsoft.Json.JsonConvert.DeserializeObject<");
            flagCode.Should().Contain("global::Newtonsoft.Json.JsonConvert.DeserializeObject<");
            payloadCode.Should().Contain($"{payloadMethod.SuccessResponse.Type.CSharpTypeWithoutNullability}.FromJson(");
        }
    }
}
