//HintName: G.IAgentsPlatformClient.Search.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Smart Search Conversation Messages<br/>
        /// Search conversation transcripts by semantic similarity to surface relevant messages based on meaning and intent, rather than exact keyword matches
        /// </summary>
        /// <param name="textQuery">
        /// The search query text for semantic similarity matching
        /// </param>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="pageSize">
        /// Number of results per page. Max 50.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessagesSearchResponse> SearchAsync(
            string textQuery,
            string? agentId = default,
            int? pageSize = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}