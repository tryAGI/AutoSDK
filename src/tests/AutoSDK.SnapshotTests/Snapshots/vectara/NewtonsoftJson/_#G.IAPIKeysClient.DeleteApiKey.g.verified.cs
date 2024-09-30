//HintName: G.IAPIKeysClient.DeleteApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// Delete an API key<br/>
        /// Delete API keys to help you manage the security and lifecycle of API keys in your application.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Error> DeleteApiKeyAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}