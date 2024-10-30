//HintName: G.Ix__AppClient.AppPublicServiceUpdateMessage.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Update a message<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateMessageResponse> AppPublicServiceUpdateMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string messageUid,
            global::G.UpdateMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a message<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageUid"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateMessageResponse> AppPublicServiceUpdateMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string messageUid,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}