//HintName: G.IConversationsClient.RetrieveConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Retrieve Conversation<br/>
        /// Retrieve a specific conversation.
        /// </summary>
        /// <param name="conversationId">
        /// The ID of the conv in the format 'conv-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Conversation> RetrieveConversationAsync(
            string conversationId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}