//HintName: G.IConversationsClient.GetConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get Conversation<br/>
        /// Returns a single conversation. Append ?verbose=true for additional event data including transcript and perception analysis.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="verbose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Conversation> GetConversationAsync(
            string conversationId,
            bool? verbose = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}