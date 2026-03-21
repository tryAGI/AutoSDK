//HintName: G.DeepgramMultichannelListenV1RealtimeClient.AudioData.g.cs

#nullable enable

namespace G
{
    public sealed partial class DeepgramMultichannelListenV1RealtimeClient
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
    }
}