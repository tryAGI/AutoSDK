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

        var hasOptions = !wsClient.Settings.HasJsonSerializerContext();
        var isValueType = wsClient.IsReceiveEventValueType || receiveEventType.IsValueType;

        string deserializeAndYield;
        if (isValueType)
        {
            // Value types (structs/anyOf) — use non-generic Deserialize with cast (no null check needed for value types)
            var deserializeCall = hasOptions
                ? $"global::System.Text.Json.JsonSerializer.Deserialize<{eventTypeName}>(json, JsonSerializerOptions)"
                : $"({eventTypeName})global::System.Text.Json.JsonSerializer.Deserialize(json, typeof({eventTypeName}), JsonSerializerContext)!";
            deserializeAndYield = $@"                    {eventTypeName} @event;
                    try
                    {{
                        @event = {deserializeCall};
                    }}
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {{
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {{
                            throw;
                        }}

                        continue;
                    }}

                    DispatchReceivedMessage(@event, json);
                    yield return @event;";
        }
        else
        {
            // Reference types — null check with ?? throw
            var deserializeCall = hasOptions
                ? $"global::System.Text.Json.JsonSerializer.Deserialize<{eventTypeName}>(json, JsonSerializerOptions)"
                : $"({eventTypeName}?)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof({eventTypeName}), JsonSerializerContext)";
            deserializeAndYield = $@"                    {eventTypeName} @event;
                    try
                    {{
                        @event = {deserializeCall} ??
                                 throw new global::System.InvalidOperationException(
                                     $""Response deserialization failed for \""{{json}}\"" "");
                    }}
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {{
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {{
                            throw;
                        }}

                        continue;
                    }}

                    DispatchReceivedMessage(@event, json);
                    yield return @event;";
        }

        var dispatchHelpers = GenerateWebSocketReceiveDispatchHelpers(wsClient, eventTypeName, isValueType);

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

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {{
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {{
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }}
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {{
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {{
                            continue;
                        }}

                        if (rethrow)
                        {{
                            throw;
                        }}

                        yield break;
                    }}
                    catch (global::System.OperationCanceledException exception)
                    {{
                        if (!cancellationToken.IsCancellationRequested)
                        {{
                            RaiseException(exception);
                        }}

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {{
                            throw;
                        }}

                        yield break;
                    }}

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {{
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: ""Closing"",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }}

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {{
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {{
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }}
                    }}

                    if (result.EndOfMessage)
                    {{
                        break;
                    }}
                }}

                if (!__receivedTextMessage)
                {{
                    continue;
                }}

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
{deserializeAndYield}
            }}
        }}

{dispatchHelpers}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateWebSocketReceiveDispatchHelpers(
        WebSocketClient wsClient,
        string eventTypeName,
        bool isValueType)
    {
        var typedDispatch = new System.Text.StringBuilder();
        var seenEventNames = new HashSet<string>(StringComparer.Ordinal);
        var receiveEventProperties = wsClient.BaseReceiveEventType.Properties.ToArray();

        foreach (var operation in wsClient.ReceiveOperations)
        {
            var messageType = operation.MessageType.CSharpTypeWithoutNullability;
            if (string.IsNullOrWhiteSpace(messageType) ||
                !CanGenerateTypedWebSocketMessageEvent(wsClient, operation.MessageType))
            {
                continue;
            }

            var eventName = operation.MessageName.ToPropertyName() + "Received";
            if (!seenEventNames.Add(eventName))
            {
                continue;
            }

            if (string.Equals(messageType, eventTypeName, StringComparison.Ordinal))
            {
                var directDispatch = $@"
            {eventName}?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<{messageType}>(
                    @event,
                    rawText,
                    json));";
                typedDispatch.Append(directDispatch);
                continue;
            }

            if (!isValueType)
            {
                var referenceDispatch = $@"
            if (@event is {messageType} __{eventName})
            {{
                {eventName}?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<{messageType}>(
                        __{eventName},
                        rawText,
                        json));
            }}";
                typedDispatch.Append(referenceDispatch);
                continue;
            }

            var preferredPropertyName = operation.MessageName.ToPropertyName();
            var messageTypePropertyName = operation.MessageType.ShortCSharpTypeWithoutNullability.ToPropertyName();
            var messageTypeWithoutPayloadPropertyName = messageTypePropertyName.EndsWith("Payload", StringComparison.Ordinal)
                ? messageTypePropertyName.Substring(0, messageTypePropertyName.Length - "Payload".Length)
                : messageTypePropertyName;
            var propertyName = receiveEventProperties.FirstOrDefault(property =>
                string.Equals(property, preferredPropertyName, StringComparison.Ordinal) ||
                string.Equals(property, messageTypePropertyName, StringComparison.Ordinal) ||
                string.Equals(property, messageTypeWithoutPayloadPropertyName, StringComparison.Ordinal));

            if (string.IsNullOrWhiteSpace(propertyName))
            {
                propertyName = preferredPropertyName;
            }

            var unionDispatch = $@"
            if (@event.{propertyName} is {{ }} __{eventName})
            {{
                {eventName}?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<{messageType}>(
                        __{eventName},
                        rawText,
                        json));
            }}";
            typedDispatch.Append(unionDispatch);
        }

        return $@"
        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {{
            try
            {{
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }}
            catch (global::System.Text.Json.JsonException)
            {{
                return null;
            }}
        }}

        private void DispatchUnknownMessage(
            string rawText)
        {{
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }}

        private void DispatchReceivedMessage(
            {eventTypeName} @event,
            string rawText)
        {{
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<{eventTypeName}>(
                    @event,
                    rawText,
                    json));
{typedDispatch}
        }}";
    }
}
