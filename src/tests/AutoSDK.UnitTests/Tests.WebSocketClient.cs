using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Parameters;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    [TestMethod]
    public void WebSocketClient_TypedConnectAsync_IncludesUriAndCancellationTokenDocs()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerContext = "G.SourceGenerationContext",
        };
        var stringType = (TypeData.Default with
        {
            CSharpTypeRaw = "string",
            CSharpTypeNullability = true,
            Namespace = "System",
            GeneratedNamespace = "G",
        }).WithCSharpComputedValues();
        var parameter = (MethodParameter.Default with
        {
            Id = "model",
            Name = "Model",
            ParameterName = "model",
            Value = "model",
            Type = stringType,
            IsRequired = false,
            Location = ParameterLocation.Query,
            Settings = settings.ToEmitterSettings(),
            Description = "The model name.",
        }).WithCSharpComputedValues();
        var client = new WebSocketClient(
            Id: "Realtime",
            ClassName: "RealtimeClient",
            FileNameWithoutExtension: "G.RealtimeClient",
            InterfaceFileNameWithoutExtension: "G.IRealtimeClient",
            BaseUrl: "wss://example.com/realtime",
            Protocol: string.Empty,
            SendOperations: ImmutableArray<WebSocketEndPoint>.Empty.AsEquatableArray(),
            ReceiveOperations: ImmutableArray<WebSocketEndPoint>.Empty.AsEquatableArray(),
            Authorizations: ImmutableArray<Authorization>.Empty.AsEquatableArray(),
            QueryParameters: ImmutableArray.Create(parameter).AsEquatableArray(),
            SerializedQueryParameters: ImmutableArray.Create(parameter).AsEquatableArray(),
            Summary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);

        var source = Sources.WebSocketClient(client).Text;

        source.Should().Contain("/// <param name=\"uri\">Optional WebSocket endpoint override.</param>");
        source.Should().Contain("/// <param name=\"additionalHeaders\">Additional headers applied before connecting.</param>");
        source.Should().Contain("/// <param name=\"connectTimeout\">Optional connect timeout.</param>");
        source.Should().Contain("/// <param name=\"cancellationToken\">A cancellation token.</param>");
    }

    [TestMethod]
    public void WebSocketReceiveMethod_AccumulatesFragments_AndExposesExceptionHook()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerContext = "G.SourceGenerationContext",
        };
        var receiveEventType = (TypeData.Default with
        {
            CSharpTypeRaw = "ServerEvent",
            Namespace = "G",
            GeneratedNamespace = "G",
        }).WithCSharpComputedValues();
        var client = new WebSocketClient(
            Id: "Realtime",
            ClassName: "RealtimeClient",
            FileNameWithoutExtension: "G.RealtimeClient",
            InterfaceFileNameWithoutExtension: "G.IRealtimeClient",
            BaseUrl: "wss://example.com/realtime",
            Protocol: string.Empty,
            SendOperations: ImmutableArray<WebSocketEndPoint>.Empty.AsEquatableArray(),
            ReceiveOperations: ImmutableArray<WebSocketEndPoint>.Empty.AsEquatableArray(),
            Authorizations: ImmutableArray<Authorization>.Empty.AsEquatableArray(),
            QueryParameters: ImmutableArray<MethodParameter>.Empty.AsEquatableArray(),
            SerializedQueryParameters: ImmutableArray<MethodParameter>.Empty.AsEquatableArray(),
            Summary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty)
        {
            BaseReceiveEventType = receiveEventType,
        };

        var clientSource = Sources.WebSocketClient(client).Text;
        var receiveSource = Sources.WebSocketReceiveMethod(client).Text;

        clientSource.Should().Contain("partial void OnReceiveException(");
        receiveSource.Should().Contain("using var __messageBuffer = new global::System.IO.MemoryStream();");
        receiveSource.Should().Contain("if (result.EndOfMessage)");
        receiveSource.Should().Contain("__messageBuffer.Write(buffer, 0, result.Count);");
        receiveSource.Should().Contain("OnReceiveException(exception, ref rethrow);");
        receiveSource.Should().Contain("if (!__receivedTextMessage)");
    }

    [TestMethod]
    public void AsyncApiServerVariables_GenerateTypedConnectAsync_UsesTemplateAndConnectionOptions()
    {
        const string yaml = """
asyncapi: 3.0.0
info:
  title: Realtime API
  version: 1.0.0
servers:
  production:
    host: "{region}.example.com"
    pathname: /v1/realtime
    protocol: wss
    variables:
      region:
        description: Region name.
        default: us
      model:
        description: Realtime model identifier.
channels:
  realtime:
    address: /v1/realtime
    messages:
      Ping:
        payload:
          type: object
operations:
  sendPing:
    action: send
    channel:
      $ref: '#/channels/realtime'
    messages:
      - $ref: '#/channels/realtime/messages/Ping'
""";

        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerContext = "G.SourceGenerationContext",
        };

        var data = AsyncApiData.Prepare(((yaml, settings), GlobalSettings: settings));
        var client = data.WebSocketClients.Should().ContainSingle().Subject;
        var source = Sources.WebSocketClient(client).Text;

        client.BaseUrl.Should().Be("wss://us.example.com/v1/realtime");
        client.BaseUrlTemplate.Should().Be("wss://{region}.example.com/v1/realtime");
        source.Should().Contain("private const string DefaultBaseUrlTemplate = \"wss://{region}.example.com/v1/realtime\";");
        source.Should().Contain("string model,");
        source.Should().Contain("string region = \"us\"");
        source.Should().Contain("__baseUrl = __baseUrl.Replace(\"{region}\", global::System.Uri.EscapeDataString(region));");
        source.Should().Contain(".AddRequiredParameter(\"model\", model)");
        source.Should().Contain("global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null");
        source.Should().Contain("global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null");
        source.Should().Contain("_clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;");
        source.Should().Contain("global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken)");
    }

    [TestMethod]
    public void WebSocketBinaryPayloadHelpers_GenerateDecodedBytesProperty_AndConvenienceSendOverload()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerContext = "G.SourceGenerationContext",
        };
        var stringType = (TypeData.Default with
        {
            CSharpTypeRaw = "string",
            CSharpTypeNullability = false,
            Namespace = "System",
            GeneratedNamespace = "G",
        }).WithCSharpComputedValues();
        var optionalStringType = (stringType with
        {
            CSharpTypeNullability = true,
        }).WithCSharpComputedValues();
        var payloadModel = new ModelData(
            SchemaContext: null!,
            Id: "InputAudioBufferAppendPayload",
            Parents: ImmutableArray<Box>.Empty,
            Namespace: "G",
            Settings: settings.ToEmitterSettings(),
            Style: ModelStyle.Class,
            Properties:
            [
                (PropertyData.Default with
                {
                    Id = "event_id",
                    Name = "EventId",
                    ParameterName = "eventId",
                    Type = optionalStringType,
                    Description = "Optional client-generated ID.",
                }),
                (PropertyData.Default with
                {
                    Id = "audio",
                    Name = "Audio",
                    ParameterName = "audio",
                    Type = stringType,
                    IsRequired = true,
                    Description = "Base64-encoded audio bytes.",
                }),
            ],
            EnumValues: [],
            IsOpenEnum: false,
            Summary: "Append input audio.",
            Description: string.Empty,
            IsDeprecated: false,
            DeprecationMessage: string.Empty,
            BaseClass: string.Empty,
            HasDeprecatedBaseClass: false,
            IsBaseClass: false,
            IsDerivedClass: false,
            InheritedPropertyNames: [],
            InheritedRequiredProperties: [],
            DiscriminatorPropertyName: string.Empty,
            DerivedTypes: [],
            ClassName: "InputAudioBufferAppendPayload",
            GlobalClassName: "global::G.InputAudioBufferAppendPayload",
            ExternalClassName: string.Empty,
            FileNameWithoutExtension: "G.Models.InputAudioBufferAppendPayload");
        var endPoint = new WebSocketEndPoint(
            Id: "InputAudioBufferAppend",
            ClassName: "RealtimeClient",
            MethodName: "SendInputAudioBufferAppendAsync",
            FileNameWithoutExtension: "G.RealtimeClient.InputAudioBufferAppend",
            ChannelAddress: "/realtime",
            Direction: WebSocketDirection.Send,
            MessageType: (TypeData.Default with
            {
                CSharpTypeRaw = "global::G.InputAudioBufferAppendPayload",
                Namespace = "G",
                GeneratedNamespace = "G",
            }).WithCSharpComputedValues(),
            MessageName: "InputAudioBufferAppend",
            Summary: "Sends audio to the realtime session.",
            Settings: settings,
            GlobalSettings: settings);

        var helperSource = Sources.ClassWebSocketBinaryPayloadHelpers(payloadModel).Text;
        var sendSource = Sources.WebSocketSendMethod(endPoint, payloadModel).Text;

        helperSource.Should().Contain("public global::System.ReadOnlyMemory<byte> AudioBytes => Audio is null");
        helperSource.Should().Contain("[global::System.Text.Json.Serialization.JsonIgnore]");
        sendSource.Should().Contain("global::System.ReadOnlyMemory<byte> audio");
        sendSource.Should().Contain("string? eventId = default");
        sendSource.Should().Contain("Audio = global::System.Convert.ToBase64String(audio.Span),");
        sendSource.Should().Contain("EventId = eventId,");
    }
}
