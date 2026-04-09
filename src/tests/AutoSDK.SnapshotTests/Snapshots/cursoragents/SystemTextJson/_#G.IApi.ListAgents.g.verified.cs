//HintName: G.IApi.ListAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List agents<br/>
        /// List all cloud agents for the authenticated user
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Example: bc_xyz789
        /// </param>
        /// <param name="prUrl">
        /// Example: https://github.com/your-org/your-repo/pull/123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAgentsResponse> ListAgentsAsync(
            int? limit = default,
            string? cursor = default,
            string? prUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}