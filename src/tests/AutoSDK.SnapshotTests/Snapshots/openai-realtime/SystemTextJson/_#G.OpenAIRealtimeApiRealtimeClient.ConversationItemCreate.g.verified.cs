//HintName: G.OpenAIRealtimeApiRealtimeClient.ConversationItemCreate.g.cs

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
        public async global::System.Threading.Tasks.Task SendConversationItemCreateAsync(
            global::G.ConversationItemCreatePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::G.ConversationItemCreatePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}