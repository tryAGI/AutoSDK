//HintName: G.IApiKeysClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update an API key<br/>
        /// The Update API Key API lets you enable or disable specific API keys. You can use this endpoint to temporarily disable access without deleting the key.<br/>
        /// This capability is useful for scenarios like maintenance windows, or when your team no longer requires access to a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> UpdateAsync(
            string apiKeyId,

            global::G.UpdateApiKeyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an API key<br/>
        /// The Update API Key API lets you enable or disable specific API keys. You can use this endpoint to temporarily disable access without deleting the key.<br/>
        /// This capability is useful for scenarios like maintenance windows, or when your team no longer requires access to a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="enabled">
        /// Indicates whether to disable or enable an API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> UpdateAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}