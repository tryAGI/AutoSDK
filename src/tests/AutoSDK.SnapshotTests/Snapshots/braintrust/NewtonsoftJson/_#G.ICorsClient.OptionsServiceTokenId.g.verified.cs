//HintName: G.ICorsClient.OptionsServiceTokenId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/service_token/{service_token_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="serviceTokenId">
        /// ServiceToken id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsServiceTokenIdAsync(
            global::System.Guid serviceTokenId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}