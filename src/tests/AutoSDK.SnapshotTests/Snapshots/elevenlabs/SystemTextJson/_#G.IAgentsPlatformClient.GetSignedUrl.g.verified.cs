//HintName: G.IAgentsPlatformClient.GetSignedUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Signed Url<br/>
        /// Get a signed url to start a conversation with an agent with an agent that requires authorization
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="includeConversationId">
        /// Whether to include a conversation_id with the response. If included, the conversation_signature cannot be used again.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationSignedUrlResponseModel> GetSignedUrlAsync(
            string agentId,
            bool? includeConversationId = default,
            string? branchId = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}