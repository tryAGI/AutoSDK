//HintName: G.OpenAIRealtimeApiRealtimeClient.ConversationItemTruncate.g.cs

#nullable enable

namespace G
{
    public sealed partial class OpenAIRealtimeApiRealtimeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendConversationItemTruncateAsync(
            global::G.ConversationItemTruncatePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.ConversationItemTruncatePayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}