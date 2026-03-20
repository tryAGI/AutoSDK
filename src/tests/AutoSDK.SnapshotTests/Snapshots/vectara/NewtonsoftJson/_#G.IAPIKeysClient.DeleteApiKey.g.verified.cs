//HintName: G.IApiKeysClient.DeleteApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete an API key<br/>
        /// The Delete API Key API lets you delete one or more existing API keys. <br/>
        /// This capability is useful for managing the lifecycle and security of <br/>
        /// API keys such as when they are no longer needed or when a key is compromised.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteApiKeyAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}