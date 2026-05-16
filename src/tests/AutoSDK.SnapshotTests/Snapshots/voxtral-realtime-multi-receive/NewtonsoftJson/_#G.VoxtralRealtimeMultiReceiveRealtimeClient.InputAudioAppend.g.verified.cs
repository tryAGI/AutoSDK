//HintName: G.VoxtralRealtimeMultiReceiveRealtimeClient.InputAudioAppend.g.cs

#nullable enable

namespace G
{
    public sealed partial class VoxtralRealtimeMultiReceiveRealtimeClient
    {
        /// <summary>
        /// Append audio bytes to the session buffer.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendInputAudioAppendAsync(
            global::G.InputAudioAppend message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.InputAudioAppend), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded PCM audio.
        /// </summary>
        /// <param name="data">The binary payload to send.</param>
        /// <param name="type">Must be 'input_audio.append'.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendInputAudioAppendAsync(
            global::System.ReadOnlyMemory<byte> data,
            global::G.InputAudioAppendType type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendInputAudioAppendAsync(
                new global::G.InputAudioAppend
                {
                Data = global::System.Convert.ToBase64String(data.Span),
                Type = type,
                },
                cancellationToken);
        }
    }
}