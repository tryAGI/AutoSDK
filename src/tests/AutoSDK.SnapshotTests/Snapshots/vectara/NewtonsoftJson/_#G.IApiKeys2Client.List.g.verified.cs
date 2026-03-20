//HintName: G.IApiKeys2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeys2Client
    {
        /// <summary>
        /// List API keys<br/>
        /// The List API Keys API lists all existing API keys for a customer ID. It also shows what corpora are accessed by these keys and with what permissions. This capability can provide insights into key usage and status and help you manage the lifecycle and security of your API keys.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="apiKeyRole">
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListApiKeysResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            string? corpusKey = default,
            global::G.ApiKeyRole? apiKeyRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}