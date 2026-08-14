using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    private const string DirectionAwareSpec = """
openapi: 3.0.3
info:
  title: Direction Aware
  version: 1.0.0
paths:
  /items:
    post:
      operationId: createItem
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CreateItemRequest'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ItemResponse'
        '400':
          description: Bad request
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ErrorResponse'
  /echo:
    post:
      operationId: echoItem
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/SharedModel'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedModel'
  /shapes:
    get:
      operationId: listShapes
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: array
                items:
                  $ref: '#/components/schemas/Shape'
components:
  schemas:
    CreateItemRequest:
      type: object
      properties:
        payload:
          $ref: '#/components/schemas/RequestPayload'
        mode:
          $ref: '#/components/schemas/RequestMode'
    RequestPayload:
      type: object
      properties:
        name:
          type: string
    RequestMode:
      type: string
      enum: [fast, thorough]
    ItemResponse:
      type: object
      properties:
        items:
          type: array
          items:
            $ref: '#/components/schemas/ResponseItem'
    ResponseItem:
      type: object
      properties:
        id:
          type: string
    ErrorResponse:
      type: object
      properties:
        message:
          type: string
    SharedModel:
      type: object
      properties:
        value:
          type: string
    UnusedModel:
      type: object
      properties:
        note:
          type: string
    Shape:
      type: object
      required:
        - kind
      properties:
        kind:
          type: string
      discriminator:
        propertyName: kind
        mapping:
          circle: '#/components/schemas/Circle'
    Circle:
      allOf:
        - $ref: '#/components/schemas/Shape'
        - type: object
          properties:
            radius:
              type: number
""";

    [TestMethod]
    public Task DirectionAwareJsonGenerationMode_Enabled_NarrowsSingleDirectionRegistrations()
    {
        return VerifyDirectionAwareContextAsync(directionAware: true);
    }

    [TestMethod]
    public Task DirectionAwareJsonGenerationMode_Disabled_KeepsDefaultRegistrations()
    {
        return VerifyDirectionAwareContextAsync(directionAware: false);
    }

    private Task VerifyDirectionAwareContextAsync(bool directionAware)
    {
        var settings = Settings.Default with
        {
            TargetFramework = "net10.0",
            Namespace = "G",
            ClassName = "DirectionAwareClient",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "G.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
            GenerateSdk = true,
            GenerateModels = true,
            GenerateConstructors = true,
            DirectionAwareJsonGenerationMode = directionAware,
        };

        var data = CSharpPipeline.PrepareAndEnrich(((DirectionAwareSpec, settings), settings));
        var file = Sources.JsonSerializerContext(data.Converters, data.Types);

        var verification = Verify(file.Text)
            .UseDirectory($"Snapshots/DirectionAwareJsonGenerationMode/{(directionAware ? "Enabled" : "Disabled")}")
            .UseFileName("_");
        if (AutoVerifyEnabled)
        {
            verification = verification.AutoVerify();
        }

        return verification;
    }
}
