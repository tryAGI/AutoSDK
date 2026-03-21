//HintName: G.DeepgramConstDiscriminatorSpeakV1RealtimeClient.SpeakRequest.g.cs

#nullable enable

namespace G
{
    public sealed partial class DeepgramConstDiscriminatorSpeakV1RealtimeClient
    {
        /// <summary>
        /// Send text-to-speech request.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendSpeakRequestAsync(
            global::G.SpeakRequestPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.SpeakRequestPayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}