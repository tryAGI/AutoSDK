//HintName: G.XaiRealtimeVoiceAgentRealtimeClient.ConversationItemCreate.g.cs

#nullable enable

namespace G
{
    public sealed partial class XaiRealtimeVoiceAgentRealtimeClient
    {
        /// <summary>
        /// Add a user message or function call output to the conversation.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendConversationItemCreateAsync(
            global::G.ConversationItemCreatePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.ConversationItemCreatePayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}