//HintName: G.XaiRealtimeVoiceAgentRealtimeClient.ResponseCreate.g.cs

#nullable enable

namespace G
{
    public sealed partial class XaiRealtimeVoiceAgentRealtimeClient
    {
        /// <summary>
        /// Request a response from the model.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendResponseCreateAsync(
            global::G.ResponseCreatePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.ResponseCreatePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}