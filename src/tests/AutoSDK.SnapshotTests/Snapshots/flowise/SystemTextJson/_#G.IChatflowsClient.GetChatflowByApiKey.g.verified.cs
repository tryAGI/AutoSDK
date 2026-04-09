//HintName: G.IChatflowsClient.GetChatflowByApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// Get chatflow by API key<br/>
        /// Retrieve a chatflow using an API key
        /// </summary>
        /// <param name="apikey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Chatflow> GetChatflowByApiKeyAsync(
            string apikey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}