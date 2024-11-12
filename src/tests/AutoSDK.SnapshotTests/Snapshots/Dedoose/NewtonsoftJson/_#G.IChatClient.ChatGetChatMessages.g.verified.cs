//HintName: G.IChatClient.ChatGetChatMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// GetChatMessages.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="lastRevievedProjectMessageId"></param>
        /// <param name="lastRecievedGlobalMessageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatMessageVO>> ChatGetChatMessagesAsync(
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Guid? projectId = default,
            global::System.Guid? lastRevievedProjectMessageId = default,
            global::System.Guid? lastRecievedGlobalMessageId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}