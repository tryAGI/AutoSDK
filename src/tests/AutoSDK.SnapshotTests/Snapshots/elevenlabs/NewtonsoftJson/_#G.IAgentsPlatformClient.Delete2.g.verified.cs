//HintName: G.IAgentsPlatformClient.Delete2.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Conversation<br/>
        /// Delete a particular conversation
        /// </summary>
        /// <param name="conversationId">
        /// The id of the conversation you're taking the action on.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Delete2Async(
            string conversationId,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}