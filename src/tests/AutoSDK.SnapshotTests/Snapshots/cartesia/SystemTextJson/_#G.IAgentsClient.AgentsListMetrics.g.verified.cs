//HintName: G.IAgentsClient.AgentsListMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Metrics<br/>
        /// List of all LLM-as-a-Judge metrics owned by your account.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="startingAfter"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListMetricsResponse> AgentsListMetricsAsync(
            global::G.AgentsListMetricsCartesiaVersion cartesiaVersion,
            string? startingAfter = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}