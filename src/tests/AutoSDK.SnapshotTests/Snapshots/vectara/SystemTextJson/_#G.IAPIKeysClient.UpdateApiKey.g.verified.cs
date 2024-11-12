//HintName: G.IAPIKeysClient.UpdateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// Update an API key<br/>
        /// Update an API key such as the roles attached to the key.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> UpdateApiKeyAsync(
            string apiKeyId,
            global::G.UpdateApiKeyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an API key<br/>
        /// Update an API key such as the roles attached to the key.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="enabled">
        /// Indicates whether to disable or enable an API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> UpdateApiKeyAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}