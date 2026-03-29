//HintName: G.IConversationsClient.ListConversations.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// List Conversations<br/>
        /// Returns a list of all conversations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListConversationsResponse> ListConversationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}