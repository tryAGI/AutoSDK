//HintName: G.IRootClient.WeaviateRoot.g.cs
#nullable enable

namespace G
{
    public partial interface IRootClient
    {
        /// <summary>
        /// List available endpoints<br/>
        /// Get links to other endpoints to help discover the REST API
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WeaviateRootResponse> WeaviateRootAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}