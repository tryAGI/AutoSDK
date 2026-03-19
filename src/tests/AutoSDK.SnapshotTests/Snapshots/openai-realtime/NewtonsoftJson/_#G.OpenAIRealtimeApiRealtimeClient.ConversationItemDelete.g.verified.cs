//HintName: G.OpenAIRealtimeApiRealtimeClient.ConversationItemDelete.g.cs

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
        public async global::System.Threading.Tasks.Task SendConversationItemDeleteAsync(
            global::G.ConversationItemDeletePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.ConversationItemDeletePayload), JsonSerializerOptions);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}