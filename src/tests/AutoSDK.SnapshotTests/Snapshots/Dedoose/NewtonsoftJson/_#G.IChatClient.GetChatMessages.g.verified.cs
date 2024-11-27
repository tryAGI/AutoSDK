//HintName: G.IChatClient.GetChatMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// GetChatMessages<br/>
        /// GetChatMessages
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatMessageVO>> GetChatMessagesAsync(
            global::G.GetChatMessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetChatMessages<br/>
        /// GetChatMessages
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="lastRevievedProjectMessageId"></param>
        /// <param name="lastRecievedGlobalMessageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatMessageVO>> GetChatMessagesAsync(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid? lastRevievedProjectMessageId,
            global::System.Guid? lastRecievedGlobalMessageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}