//HintName: G.IToolServersClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IToolServersClient
    {
        /// <summary>
        /// List tool servers<br/>
        /// Retrieve a list of available tool servers that expose various tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: rag.*
        /// </param>
        /// <param name="type">
        /// Example: mcp
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListToolServersResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            global::G.ListToolServersType? type = default,
            bool? enabled = default,
            int? limit = default,
            string? pageKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}