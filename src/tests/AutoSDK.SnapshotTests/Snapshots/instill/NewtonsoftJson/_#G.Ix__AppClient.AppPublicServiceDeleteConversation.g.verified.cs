//HintName: G.Ix__AppClient.AppPublicServiceDeleteConversation.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Delete a conversation<br/>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}