using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using AutoSDK.TypeMapping;

namespace AutoSDK.UnitTests;

[TestClass]
public class JsonGenerationModeTests
{
    private const string DirectionSpec = """
                                         openapi: 3.0.3
                                         info:
                                           title: Direction
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
                                                         $ref: '#/components/schemas/Shape'
                                         components:
                                           schemas:
                                             CreateItemRequest:
                                               type: object
                                               properties:
                                                 payload:
                                                   $ref: '#/components/schemas/RequestPayload'
                                             RequestPayload:
                                               type: object
                                               properties:
                                                 name:
                                                   type: string
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

    private static Settings CliSettings => Settings.Default with
    {
        TargetFramework = "net10.0",
        Namespace = "G",
        ClassName = "Api",
        JsonSerializerType = JsonSerializerType.SystemTextJson,
        JsonSerializerContext = "G.SourceGenerationContext",
        GenerateJsonSerializerContextTypes = true,
        FromCli = true,
        GenerateSdk = true,
        GenerateModels = true,
        GenerateConstructors = true,
    };

    private static Models.Data Prepare(Settings settings)
    {
        return AutoSDK.Generation.Data.Prepare(
            ((DirectionSpec, (CSharpSettings)settings), (CSharpSettings)settings));
    }

    private static JsonSerializationDirection DirectionOf(Models.Data data, string type)
    {
        return data.Types
            .Where(x => x.CSharpTypeWithoutNullability == type)
            .Select(x => x.JsonSerializationDirection)
            .Aggregate(JsonSerializationDirection.None, static (left, right) => left | right);
    }

    [TestMethod]
    public void Analyze_ClassifiesRequestResponseAndBidirectionalTypes()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        DirectionOf(data, "global::G.CreateItemRequest").Should().Be(JsonSerializationDirection.Request);
        DirectionOf(data, "global::G.ItemResponse").Should().Be(JsonSerializationDirection.Response);
        DirectionOf(data, "global::G.SharedModel").Should().Be(JsonSerializationDirection.Both);
    }

    [TestMethod]
    public void Analyze_PropagatesThroughNestedReferencesAndArrays()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        DirectionOf(data, "global::G.RequestPayload").Should().Be(JsonSerializationDirection.Request);
        DirectionOf(data, "global::G.ResponseItem").Should().Be(JsonSerializationDirection.Response);
        DirectionOf(data, "global::System.Collections.Generic.IList<global::G.ResponseItem>")
            .Should().Be(JsonSerializationDirection.Response);
    }

    [TestMethod]
    public void Analyze_CountsErrorResponsesAsResponseUsage()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        DirectionOf(data, "global::G.ErrorResponse").Should().Be(JsonSerializationDirection.Response);
    }

    [TestMethod]
    public void Analyze_PropagatesDirectionToDiscriminatorMappedSubtypes()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        DirectionOf(data, "global::G.Shape").Should().Be(JsonSerializationDirection.Response);
        DirectionOf(data, "global::G.Circle").Should().Be(JsonSerializationDirection.Response);
    }

    [TestMethod]
    public void Analyze_LeavesUnreachableModelsAmbiguous()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        data.Types.Should().Contain(x => x.CSharpTypeWithoutNullability == "global::G.UnusedModel");
        DirectionOf(data, "global::G.UnusedModel").Should().Be(JsonSerializationDirection.None);

        var file = Sources.JsonSerializerContext(data.Converters, data.Types);

        file.Text.Should().Contain("JsonSerializable(typeof(global::G.UnusedModel))");
    }

    [TestMethod]
    public void Analyze_IsSkippedWhenTheOptionIsOff()
    {
        var data = Prepare(CliSettings);

        data.Types.Should().NotBeEmpty();
        data.Types.Should().OnlyContain(x => x.JsonSerializationDirection == JsonSerializationDirection.None);
    }

    [TestMethod]
    public void JsonSerializerContext_KeepsDefaultModeWhenTheOptionIsOff()
    {
        var data = Prepare(CliSettings);

        var file = Sources.JsonSerializerContext(data.Converters, data.Types);

        file.Text.Should().Contain("JsonSerializable(typeof(global::G.ItemResponse))");
        file.Text.Should().NotContain("GenerationMode");
    }

    [TestMethod]
    public void JsonSerializerContext_NarrowsSingleDirectionTypesToMetadataWhenConvertersDisableTheFastPath()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        // Generated SDKs always register at least the unix timestamp converter, which turns off
        // fast-path serialization for the whole context.
        data.Converters.Converters.Should().NotBeEmpty();

        var file = Sources.JsonSerializerContext(data.Converters, data.Types);

        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::G.ItemResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::G.CreateItemRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
        file.Text.Should().NotContain("JsonSourceGenerationMode.Serialization");
        file.Text.Should().Contain("JsonSerializable(typeof(global::G.SharedModel))");
        file.Text.Should().Contain("JsonSerializable(typeof(global::G.UnusedModel))");
        file.Text.Should().Contain("JsonSerializable(typeof(global::G.JsonSerializerContextTypes))");
    }

    [TestMethod]
    public void JsonSerializerContext_NarrowsRequestOnlyTypesToSerializationWhenNoConvertersAreRegistered()
    {
        var settings = CliSettings with { DirectionAwareJsonGenerationMode = true };
        var client = CreateClient(settings, converters: ImmutableArray<string>.Empty);
        var types = ImmutableArray.Create(
                RequestType("global::System.Collections.Generic.IList<global::G.CreateItemRequest>", isArray: true),
                ResponseType("global::G.ItemResponse"),
                BidirectionalType("global::G.SharedModel"))
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::System.Collections.Generic.IList<global::G.CreateItemRequest>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Serialization)");
        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::G.ItemResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
        file.Text.Should().Contain("JsonSerializable(typeof(global::G.SharedModel))");
    }

    [TestMethod]
    public void JsonSerializerContext_KeepsDefaultModeForRequestOnlyTypesThatGenerateFromJsonHelpers()
    {
        var settings = CliSettings with { DirectionAwareJsonGenerationMode = true };
        var client = CreateClient(settings, converters: ImmutableArray<string>.Empty);
        var requestModel = RequestType("global::G.CreateItemRequest");
        requestModel.UsesGeneratedJsonHelpers = true;
        var types = ImmutableArray.Create(requestModel).AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        file.Text.Should().Contain("JsonSerializable(typeof(global::G.CreateItemRequest))");
        file.Text.Should().NotContain("GenerationMode");
    }

    [TestMethod]
    public void JsonSerializerContext_AppliesGenerationModeToDerivedConcreteListRegistrations()
    {
        var settings = CliSettings with { DirectionAwareJsonGenerationMode = true };
        var client = CreateClient(settings, converters: ImmutableArray<string>.Empty);
        var types = ImmutableArray.Create(
                ResponseType("global::System.Collections.Generic.IList<global::G.ResponseItem>", isArray: true))
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::System.Collections.Generic.List<global::G.ResponseItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
    }

    [TestMethod]
    public void JsonSerializerContext_AppliesGenerationModeInsideSplitContexts()
    {
        var settings = CliSettings with { DirectionAwareJsonGenerationMode = true };
        var client = CreateClient(settings, converters: ImmutableArray<string>.Empty);
        var types = Enumerable.Range(0, 520)
            .Select(index => ResponseType($"global::G.Model{index}"))
            .ToImmutableArray()
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        file.Text.Should().Contain("internal sealed partial class SourceGenerationContextChunk0");
        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::G.Model0), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
        file.Text.Should().Contain(
            "JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))");
    }

    [TestMethod]
    public void CreateReport_CountsEachClassificationBucket()
    {
        var data = Prepare(CliSettings with { DirectionAwareJsonGenerationMode = true });

        var report = JsonSerializationDirectionAnalyzer.CreateReport(data);

        report.RequestOnly.Should().BeGreaterThan(0);
        report.ResponseOnly.Should().BeGreaterThan(0);
        report.Bidirectional.Should().BeGreaterThan(0);
        report.Unclassified.Should().BeGreaterThan(0);
        report.Total.Should().Be(
            report.RequestOnly + report.ResponseOnly + report.Bidirectional + report.Unclassified);

        // The generated unix timestamp converter is always registered.
        report.FastPathAvailable.Should().BeFalse();
        report.ToString().Should().StartWith("Direction-aware JSON generation modes: ");
        report.ToString().Should().Contain("Registered converters disable source-generated fast-path serialization");
    }

    [TestMethod]
    public void CreateReport_CountsEverythingUnclassifiedWhenTheOptionIsOff()
    {
        var data = Prepare(CliSettings);

        var report = JsonSerializationDirectionAnalyzer.CreateReport(data);

        report.Total.Should().BeGreaterThan(0);
        report.Unclassified.Should().Be(report.Total);
        report.RequestOnly.Should().Be(0);
        report.ResponseOnly.Should().Be(0);
        report.Bidirectional.Should().Be(0);
    }

    [TestMethod]
    public void CreateReport_ReportsSerializationNarrowingWhenNoConvertersAreRegistered()
    {
        var report = new JsonSerializationDirectionReport(
            requestOnly: 2,
            responseOnly: 3,
            bidirectional: 1,
            unclassified: 0,
            fastPathAvailable: true);

        report.Total.Should().Be(6);
        report.ToString().Should().Be(
            "Direction-aware JSON generation modes: 2 request-only, 3 response-only, 1 bidirectional, 0 unclassified of 6 registered types. " +
            "Request-only types without generated FromJson helpers use Serialization; response-only types use Metadata.");
    }

    private const string AsyncApiSpec = """
asyncapi: 3.0.0
info:
  title: Realtime
  version: 1.0.0
servers:
  production:
    host: example.com
    pathname: /v1/realtime
    protocol: wss
channels:
  realtime:
    address: /v1/realtime
    messages:
      SessionUpdate:
        payload:
          $ref: '#/components/schemas/SessionUpdate'
      SessionCreated:
        payload:
          $ref: '#/components/schemas/SessionCreated'
operations:
  sendSessionUpdate:
    action: send
    channel:
      $ref: '#/channels/realtime'
    messages:
      - $ref: '#/channels/realtime/messages/SessionUpdate'
  receiveSessionCreated:
    action: receive
    channel:
      $ref: '#/channels/realtime'
    messages:
      - $ref: '#/channels/realtime/messages/SessionCreated'
components:
  schemas:
    SessionUpdate:
      type: object
      properties:
        session:
          $ref: '#/components/schemas/SessionConfig'
    SessionConfig:
      type: object
      properties:
        model:
          type: string
    SessionCreated:
      type: object
      properties:
        session:
          $ref: '#/components/schemas/SessionState'
    SessionState:
      type: object
      properties:
        id:
          type: string
""";

    [TestMethod]
    public void Analyze_MapsAsyncApiSendAndReceiveOperationsToDirections()
    {
        var settings = CliSettings with { DirectionAwareJsonGenerationMode = true };

        var data = AsyncApiData.Prepare(((AsyncApiSpec, settings), GlobalSettings: settings));

        DirectionOf(data, "global::G.SessionUpdate").Should().Be(JsonSerializationDirection.Request);
        DirectionOf(data, "global::G.SessionConfig").Should().Be(JsonSerializationDirection.Request);
        DirectionOf(data, "global::G.SessionCreated").Should().Be(JsonSerializationDirection.Response);
        DirectionOf(data, "global::G.SessionState").Should().Be(JsonSerializationDirection.Response);
    }

    [TestMethod]
    public void Analyze_IsSkippedForAsyncApiWhenTheOptionIsOff()
    {
        var data = AsyncApiData.Prepare(((AsyncApiSpec, CliSettings), GlobalSettings: CliSettings));

        data.Types.Should().NotBeEmpty();
        data.Types.Should().OnlyContain(x => x.JsonSerializationDirection == JsonSerializationDirection.None);
    }

    private static Client CreateClient(Settings settings, ImmutableArray<string> converters)
    {
        return new Client(
            Id: "Converters",
            ClassName: "ApiClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: converters);
    }

    private static TypeData RequestType(string type, bool isArray = false)
    {
        return CreateType(type, JsonSerializationDirection.Request, isArray);
    }

    private static TypeData ResponseType(string type, bool isArray = false)
    {
        return CreateType(type, JsonSerializationDirection.Response, isArray);
    }

    private static TypeData BidirectionalType(string type, bool isArray = false)
    {
        return CreateType(type, JsonSerializationDirection.Both, isArray);
    }

    private static TypeData CreateType(
        string type,
        JsonSerializationDirection direction,
        bool isArray)
    {
        var typeData = (TypeData.Default with
        {
            Namespace = isArray ? "System.Collections.Generic" : "G",
            GeneratedNamespace = "G",
            CSharpTypeRaw = type,
            IsArray = isArray,
        }).WithCSharpComputedValues();
        typeData.JsonSerializationDirection = direction;

        return typeData;
    }
}
