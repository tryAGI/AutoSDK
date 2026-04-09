//HintName: G.IToolkitsClient.GetToolkitsChangelog.g.cs
#nullable enable

namespace G
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Get toolkits changelog<br/>
        /// Retrieves the last 10 versions changelog for all toolkits. This endpoint provides version history and changelog information for each toolkit.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetToolkitsChangelogResponse> GetToolkitsChangelogAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}