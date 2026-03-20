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
            global::ExternalTypes.InputAudioChunkPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::ExternalTypes.InputAudioChunkPayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}