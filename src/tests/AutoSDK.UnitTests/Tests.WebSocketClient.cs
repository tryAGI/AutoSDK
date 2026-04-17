using System.Collections.Immutable;
using AutoSDK.Generation;
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
}
