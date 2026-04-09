//HintName: G.IAnalyticsClient.AnalyticsControllerQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Create Analytics Queries
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnalyticsQueryResult>> AnalyticsControllerQueryAsync(

            global::G.AnalyticsQueryDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Analytics Queries
        /// </summary>
        /// <param name="queries">
        /// This is the list of metric queries you want to perform.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnalyticsQueryResult>> AnalyticsControllerQueryAsync(
            global::System.Collections.Generic.IList<global::G.AnalyticsQuery> queries,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}