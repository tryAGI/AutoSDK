//HintName: G.IAPIKeysClient.ListApiKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IAPIKeysClient
    {
        /// <summary>
        /// List API keys
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListApiKeysResponse> ListApiKeysAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = 10,
            string? pageKey = default,
            string? corpusKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}