//HintName: G.IMlClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Get ML Backend<br/>
        ///     Get details about a specific ML backend connection by ID. For example, make a GET request using the<br/>
        ///     following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MLBackend> GetAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}