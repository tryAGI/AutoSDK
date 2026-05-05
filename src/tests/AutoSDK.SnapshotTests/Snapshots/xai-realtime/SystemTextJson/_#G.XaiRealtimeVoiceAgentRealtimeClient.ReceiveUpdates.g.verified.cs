//HintName: G.XaiRealtimeVoiceAgentRealtimeClient.ReceiveUpdates.g.cs

#nullable enable

namespace G
{
    public sealed partial class XaiRealtimeVoiceAgentRealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.ServerEvent> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            continue;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (global::System.OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: "Closing",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (!__receivedTextMessage)
                {
                    continue;
                }

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
                    global::G.ServerEvent @event;
                    try
                    {
                        @event = (global::G.ServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::G.ServerEvent), JsonSerializerContext)!;
                    }
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {
                            throw;
                        }

                        continue;
                    }

                    DispatchReceivedMessage(@event, json);
                    yield return @event;
            }
        }


        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {
            try
            {
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }
            catch (global::System.Text.Json.JsonException)
            {
                return null;
            }
        }

        private void DispatchUnknownMessage(
            string rawText)
        {
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }

        private void DispatchReceivedMessage(
            global::G.ServerEvent @event,
            string rawText)
        {
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<global::G.ServerEvent>(
                    @event,
                    rawText,
                    json));

            if (@event.SessionCreated is { } __SessionCreatedReceived)
            {
                SessionCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.SessionCreatedEvent>(
                        __SessionCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.SessionUpdated is { } __SessionUpdatedReceived)
            {
                SessionUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.SessionUpdatedEvent>(
                        __SessionUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationCreated is { } __ConversationCreatedReceived)
            {
                ConversationCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ConversationCreatedEvent>(
                        __ConversationCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemAdded is { } __ConversationItemAddedReceived)
            {
                ConversationItemAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ConversationItemAddedEvent>(
                        __ConversationItemAddedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferSpeechStarted is { } __InputAudioBufferSpeechStartedReceived)
            {
                InputAudioBufferSpeechStartedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.InputAudioBufferSpeechStartedEvent>(
                        __InputAudioBufferSpeechStartedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferSpeechStopped is { } __InputAudioBufferSpeechStoppedReceived)
            {
                InputAudioBufferSpeechStoppedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.InputAudioBufferSpeechStoppedEvent>(
                        __InputAudioBufferSpeechStoppedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferCommitted is { } __InputAudioBufferCommittedReceived)
            {
                InputAudioBufferCommittedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.InputAudioBufferCommittedEvent>(
                        __InputAudioBufferCommittedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioTranscriptionCompleted is { } __InputAudioTranscriptionCompletedReceived)
            {
                InputAudioTranscriptionCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.InputAudioTranscriptionCompletedEvent>(
                        __InputAudioTranscriptionCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseCreated is { } __ResponseCreatedReceived)
            {
                ResponseCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseCreatedEvent>(
                        __ResponseCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseDone is { } __ResponseDoneReceived)
            {
                ResponseDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseDoneEvent>(
                        __ResponseDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputItemAdded is { } __ResponseOutputItemAddedReceived)
            {
                ResponseOutputItemAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseOutputItemAddedEvent>(
                        __ResponseOutputItemAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioTranscriptDelta is { } __ResponseOutputAudioTranscriptDeltaReceived)
            {
                ResponseOutputAudioTranscriptDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseOutputAudioTranscriptDeltaEvent>(
                        __ResponseOutputAudioTranscriptDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioTranscriptDone is { } __ResponseOutputAudioTranscriptDoneReceived)
            {
                ResponseOutputAudioTranscriptDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseOutputAudioTranscriptDoneEvent>(
                        __ResponseOutputAudioTranscriptDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioDelta is { } __ResponseOutputAudioDeltaReceived)
            {
                ResponseOutputAudioDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseOutputAudioDeltaEvent>(
                        __ResponseOutputAudioDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioDone is { } __ResponseOutputAudioDoneReceived)
            {
                ResponseOutputAudioDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseOutputAudioDoneEvent>(
                        __ResponseOutputAudioDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseFunctionCallArgumentsDone is { } __ResponseFunctionCallArgumentsDoneReceived)
            {
                ResponseFunctionCallArgumentsDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseFunctionCallArgumentsDoneEvent>(
                        __ResponseFunctionCallArgumentsDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallArgumentsDone is { } __ResponseMcpCallArgumentsDoneReceived)
            {
                ResponseMcpCallArgumentsDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseMcpCallArgumentsDoneEvent>(
                        __ResponseMcpCallArgumentsDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallCompleted is { } __ResponseMcpCallCompletedReceived)
            {
                ResponseMcpCallCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseMcpCallCompletedEvent>(
                        __ResponseMcpCallCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallFailed is { } __ResponseMcpCallFailedReceived)
            {
                ResponseMcpCallFailedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ResponseMcpCallFailedEvent>(
                        __ResponseMcpCallFailedReceived,
                        rawText,
                        json));
            }
            if (@event.McpListToolsCompleted is { } __McpListToolsCompletedReceived)
            {
                McpListToolsCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.McpListToolsCompletedEvent>(
                        __McpListToolsCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.Error is { } __ErrorReceived)
            {
                ErrorReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::G.ErrorEvent>(
                        __ErrorReceived,
                        rawText,
                        json));
            }
        }
    }
}