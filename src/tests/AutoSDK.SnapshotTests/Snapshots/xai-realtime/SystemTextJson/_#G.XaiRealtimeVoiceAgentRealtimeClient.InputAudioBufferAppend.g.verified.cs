//HintName: G.XaiRealtimeVoiceAgentRealtimeClient.InputAudioBufferAppend.g.cs

#nullable enable

namespace G
{
    public sealed partial class XaiRealtimeVoiceAgentRealtimeClient
    {
        /// <summary>
        /// Append base64-encoded audio data to the input buffer.
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
        /// Base64-encoded audio data.
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="type"></param>
        /// <param name="eventId">Optional event ID.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendInputAudioBufferAppendAsync(
            global::System.ReadOnlyMemory<byte> audio,
            global::G.InputAudioBufferAppendPayloadType type = default,
            string? eventId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendInputAudioBufferAppendAsync(
                new global::G.InputAudioBufferAppendPayload
                {
                Audio = global::System.Convert.ToBase64String(audio.Span),
                Type = type,
                EventId = eventId,
                },
                cancellationToken);
        }
    }
}