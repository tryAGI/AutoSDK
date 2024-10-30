//HintName: G.Ix__AppClient.AppPublicServiceDeleteMessage.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Delete a message<br/>
        /// Deletes a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string messageUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}