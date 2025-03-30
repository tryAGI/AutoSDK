//HintName: G.IAPIKeysClient.GetApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// Get an API key<br/>
        /// Retrieve details of a specific API key by its ID.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> GetApiKeyAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}