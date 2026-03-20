//HintName: G.ElevenLabsRealtimeSpeechToTextRealtimeClient.ReceiveUpdates.g.cs

#nullable enable

namespace G
{
    public sealed partial class ElevenLabsRealtimeSpeechToTextRealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::ExternalTypes.ServerEvent> ReceiveUpdatesAsync(
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

                global::System.Net.WebSockets.WebSocketReceiveResult result;

                try
                {
                    result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                }
                catch (global::System.Net.WebSockets.WebSocketException)
                {
                    yield break;
                }
                catch (global::System.OperationCanceledException)
                {
                    yield break;
                }

                if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                {
                    string json = global::System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
                    var @event = (global::ExternalTypes.ServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::ExternalTypes.ServerEvent), JsonSerializerContext)!;

                    yield return @event;
                }
                else if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                {
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: "Closing",
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    yield break;
                }
            }
        }
    }
}