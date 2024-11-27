//HintName: G.IChatClient.SubmitProjectChatMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// SubmitProjectChatMessage<br/>
        /// SubmitProjectChatMessage
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatMessageVO> SubmitProjectChatMessageAsync(
            global::G.SubmitProjectChatMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SubmitProjectChatMessage<br/>
        /// SubmitProjectChatMessage
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatMessageVO> SubmitProjectChatMessageAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            string message,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}