//HintName: G.IChatflowsClient.GetChatflowById.g.cs
#nullable enable

namespace G
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// Get chatflow by ID<br/>
        /// Retrieve a specific chatflow by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Chatflow> GetChatflowByIdAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}