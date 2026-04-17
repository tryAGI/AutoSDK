//HintName: G.OpenAIRealtimeApiRealtimeClient.InputAudioBufferAppend.g.cs

#nullable enable

namespace G
{
    public sealed partial class OpenAIRealtimeApiRealtimeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendInputAudioBufferAppendAsync(
            global::G.InputAudioBufferAppendPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.InputAudioBufferAppendPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="eventId">Optional client-generated ID.</param>
        /// <param name="type">The event type.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendInputAudioBufferAppendAsync(
            global::System.ReadOnlyMemory<byte> audio,
            string? eventId = default,
            global::G.InputAudioBufferAppendPayloadType type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendInputAudioBufferAppendAsync(
                new global::G.InputAudioBufferAppendPayload
                {
                Audio = global::System.Convert.ToBase64String(audio.Span),
                EventId = eventId,
                Type = type,
                },
                cancellationToken);
        }
    }
}