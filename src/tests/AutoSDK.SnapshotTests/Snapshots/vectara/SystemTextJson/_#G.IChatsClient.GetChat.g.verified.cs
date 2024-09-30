//HintName: G.IChatsClient.GetChat.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Get a chat<br/>
        /// Get a chat summary to view what started the chat, but not subsequent turns.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Chat> GetChatAsync(
            string chatId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}