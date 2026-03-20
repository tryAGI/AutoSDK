//HintName: G.XaiRealtimeVoiceAgentRealtimeClient.InputAudioBufferCommit.g.cs

#nullable enable

namespace G
{
    public sealed partial class XaiRealtimeVoiceAgentRealtimeClient
    {
        /// <summary>
        /// Commit the current input audio buffer.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendInputAudioBufferCommitAsync(
            global::G.InputAudioBufferCommitPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.InputAudioBufferCommitPayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}