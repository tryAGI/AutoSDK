//HintName: G.IApiKeys2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeys2Client
    {
        /// <summary>
        /// Create an API key<br/>
        /// The Create API Key API lets you create new API keys, which you can bind to one or multiple corpora. You can also decide whether to designate each key for specific access like personal API keys, only querying (read-only) or both querying and indexing (read-write).<br/>
        /// This capability is useful in scenarios where you have applications that require different levels of access to corpora data. For example, you might create a read-only API key for an application that only needs to query data.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/deploy-and-scale/authentication/api-key-management).<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> CreateAsync(

            global::G.CreateApiKeyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key<br/>
        /// The Create API Key API lets you create new API keys, which you can bind to one or multiple corpora. You can also decide whether to designate each key for specific access like personal API keys, only querying (read-only) or both querying and indexing (read-write).<br/>
        /// This capability is useful in scenarios where you have applications that require different levels of access to corpora data. For example, you might create a read-only API key for an application that only needs to query data.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/deploy-and-scale/authentication/api-key-management).<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="name">
        /// The human-readable name of the API key.
        /// </param>
        /// <param name="apiRoles">
        /// Customer-level roles for this API key.
        /// </param>
        /// <param name="apiKeyRole">
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific role assignments for this API key.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific role assignments for this API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> CreateAsync(
            string name,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles = default,
            global::G.ApiKeyRole? apiKeyRole = default,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles = default,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}