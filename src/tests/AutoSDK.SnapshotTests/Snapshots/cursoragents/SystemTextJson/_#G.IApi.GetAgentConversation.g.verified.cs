//HintName: G.IApi.GetAgentConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get agent conversation<br/>
        /// Retrieve the conversation history of a cloud agent, including all user prompts and assistant responses
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAgentConversationResponse> GetAgentConversationAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}