//HintName: G.IToolServersClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IToolServersClient
    {
        /// <summary>
        /// Get tool Server<br/>
        /// Retrieve details about a specific tool server by its Id.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolServer> GetAsync(
            string toolServerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}