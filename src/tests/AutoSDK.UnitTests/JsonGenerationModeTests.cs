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
