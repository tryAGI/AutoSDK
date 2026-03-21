//HintName: G.DeepgramInlinePayloadsAgentV1RealtimeClient.AgentConfig.g.cs

#nullable enable

namespace G
{
    public sealed partial class DeepgramInlinePayloadsAgentV1RealtimeClient
    {
        /// <summary>
        /// Send agent configuration.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendAgentConfigAsync(
            global::G.AgentConfig message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.AgentConfig), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}