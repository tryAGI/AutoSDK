//HintName: G.ISandboxesClient.GetSandboxesMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List metrics for given sandboxes
        /// </summary>
        /// <param name="sandboxIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SandboxesWithMetrics> GetSandboxesMetricsAsync(
            global::System.Collections.Generic.IList<string> sandboxIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}