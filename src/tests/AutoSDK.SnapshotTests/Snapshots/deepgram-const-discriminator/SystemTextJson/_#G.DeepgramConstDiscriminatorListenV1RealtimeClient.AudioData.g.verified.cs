//HintName: G.DeepgramConstDiscriminatorListenV1RealtimeClient.AudioData.g.cs

#nullable enable

namespace G
{
    public sealed partial class DeepgramConstDiscriminatorListenV1RealtimeClient
    {
        /// <summary>
        /// Send audio data for transcription.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendAudioDataAsync(
            global::G.AudioDataPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.AudioDataPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        /// <param name="audioBase64">The binary payload to send.</param>
        /// <param name="messageType"></param>
        /// <param name="sampleRate">Audio sample rate in Hz.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendAudioDataAsync(
            global::System.ReadOnlyMemory<byte> audioBase64,
            string messageType = default!,
            int? sampleRate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendAudioDataAsync(
                new global::G.AudioDataPayload
                {
                AudioBase64 = global::System.Convert.ToBase64String(audioBase64.Span),
                MessageType = messageType,
                SampleRate = sampleRate,
                },
                cancellationToken);
        }
    }
}