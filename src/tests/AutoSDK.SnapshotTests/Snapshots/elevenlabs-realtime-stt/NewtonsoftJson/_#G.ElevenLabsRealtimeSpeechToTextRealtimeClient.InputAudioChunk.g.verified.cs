//HintName: G.ElevenLabsRealtimeSpeechToTextRealtimeClient.InputAudioChunk.g.cs

#nullable enable

namespace G
{
    public sealed partial class ElevenLabsRealtimeSpeechToTextRealtimeClient
    {
        /// <summary>
        /// Send an audio chunk to the server for transcription.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendInputAudioChunkAsync(
            global::G.InputAudioChunkPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.InputAudioChunkPayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        /// <param name="audioBase64">The binary payload to send.</param>
        /// <param name="commit">Whether to commit the audio buffer.</param>
        /// <param name="sampleRate">Audio sample rate in Hz.</param>
        /// <param name="messageType">Must be 'input_audio_chunk'.</param>
        /// <param name="previousText">Optional previous text context.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendInputAudioChunkAsync(
            global::System.ReadOnlyMemory<byte> audioBase64,
            bool commit,
            int sampleRate,
            global::G.InputAudioChunkPayloadMessageType messageType = default,
            string? previousText = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendInputAudioChunkAsync(
                new global::G.InputAudioChunkPayload
                {
                AudioBase64 = global::System.Convert.ToBase64String(audioBase64.Span),
                MessageType = messageType,
                Commit = commit,
                SampleRate = sampleRate,
                PreviousText = previousText,
                },
                cancellationToken);
        }
    }
}