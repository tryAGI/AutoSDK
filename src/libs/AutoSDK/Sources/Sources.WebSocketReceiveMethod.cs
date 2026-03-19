using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName WebSocketReceiveMethod(
        WebSocketClient wsClient,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{wsClient.Settings.Namespace}.{wsClient.ClassName}.ReceiveUpdates.g.cs",
            Text: GenerateWebSocketReceiveMethod(wsClient));
    }

    public static string GenerateWebSocketReceiveMethod(
        WebSocketClient wsClient)
    {
        var receiveEventType = wsClient.BaseReceiveEventType;
        // CSharpType already includes global:: prefix
        var eventTypeName = receiveEventType.CSharpTypeWithoutNullability;

        if (string.IsNullOrWhiteSpace(eventTypeName))
        {
            return string.Empty;
        }

        var hasOptions = string.IsNullOrWhiteSpace(wsClient.Settings.JsonSerializerContext);
        var isValueType = wsClient.IsReceiveEventValueType;

        string deserializeAndYield;
        if (isValueType)
        {
            // Value types (structs/anyOf) — use non-generic Deserialize with cast (no null check needed for value types)
            var deserializeCall = hasOptions
                ? $"global::System.Text.Json.JsonSerializer.Deserialize<{eventTypeName}>(json, JsonSerializerOptions)"
                : $"({eventTypeName})global::System.Text.Json.JsonSerializer.Deserialize(json, typeof({eventTypeName}), JsonSerializerContext)!";
            deserializeAndYield = $@"                    var @event = {deserializeCall};

                    yield return @event;";
        }
        else
        {
            // Reference types — null check with ?? throw
            var deserializeCall = hasOptions
                ? $"global::System.Text.Json.JsonSerializer.Deserialize<{eventTypeName}>(json, JsonSerializerOptions)"
                : $"({eventTypeName}?)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof({eventTypeName}), JsonSerializerContext)";
            deserializeAndYield = $@"                    var @event = {deserializeCall} ??
                                 throw new global::System.InvalidOperationException(
                                     $""Response deserialization failed for \""{{json}}\"" "");

                    yield return @event;";
        }

        return $@"
#nullable enable

namespace {wsClient.Settings.Namespace}
{{
    public sealed partial class {wsClient.ClassName}
    {{
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name=""cancellationToken"">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<{eventTypeName}> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (!IsConnected)
            {{
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {{
                if (cancellationToken.IsCancellationRequested)
                {{
                    yield break;
                }}

                global::System.Net.WebSockets.WebSocketReceiveResult result;

                try
                {{
                    result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                }}
                catch (global::System.Net.WebSockets.WebSocketException)
                {{
                    yield break;
                }}
                catch (global::System.OperationCanceledException)
                {{
                    yield break;
                }}

                if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                {{
                    string json = global::System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
{deserializeAndYield}
                }}
                else if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                {{
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: ""Closing"",
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    yield break;
                }}
            }}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
