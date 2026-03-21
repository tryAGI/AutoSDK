//HintName: G.DeepgramConstDiscriminatorListenV1RealtimeClient.ListenConfig.g.cs

#nullable enable

namespace G
{
    public sealed partial class DeepgramConstDiscriminatorListenV1RealtimeClient
    {
        /// <summary>
        /// Send listen configuration.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendListenConfigAsync(
            global::G.ListenConfigPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.ListenConfigPayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}