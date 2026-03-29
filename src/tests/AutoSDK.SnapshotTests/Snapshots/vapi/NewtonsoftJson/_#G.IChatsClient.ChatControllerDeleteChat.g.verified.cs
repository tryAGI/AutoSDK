//HintName: G.IChatsClient.ChatControllerDeleteChat.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Delete Chat
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Chat> ChatControllerDeleteChatAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}