//HintName: G.IAPIKeysClient.CreateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// Create an API key<br/>
        /// An API key is to authenticate when calling Vectara APIs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> CreateApiKeyAsync(
            global::G.CreateApiKeyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an API key<br/>
        /// An API key is to authenticate when calling Vectara APIs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="name">
        /// The human-readable name of the API key.
        /// </param>
        /// <param name="apiKeyRole">
        /// Role of the API key. <br/>
        /// A serving API key can only perform query type requests on its corpora. A serving and<br/>
        /// indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </param>
        /// <param name="corpusKeys">
        /// Corpora this API key has roles on if it is not a Personal API key.<br/>
        /// This property should be null or missing if this `api_key_role` is<br/>
        /// `personal`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> CreateApiKeyAsync(
            string name,
            global::G.ApiKeyRole apiKeyRole,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<string>? corpusKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}