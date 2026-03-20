//HintName: G.IAppClient.AppPublicServiceDeleteConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Delete a conversation<br/>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}