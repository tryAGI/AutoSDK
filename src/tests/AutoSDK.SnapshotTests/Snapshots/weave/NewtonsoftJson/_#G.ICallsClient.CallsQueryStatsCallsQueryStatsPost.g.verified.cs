//HintName: G.ICallsClient.CallsQueryStatsCallsQueryStatsPost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Calls Query Stats
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallsQueryStatsRes> CallsQueryStatsCallsQueryStatsPostAsync(

            global::G.CallsQueryStatsReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Query Stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="includeTotalStorageSize">
        /// Default Value: false
        /// </param>
        /// <param name="expandColumns">
        /// Columns with refs to objects or table rows that require expansion during filtering or ordering.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallsQueryStatsRes> CallsQueryStatsCallsQueryStatsPostAsync(
            string projectId,
            global::G.CallsFilter? filter = default,
            global::G.Query? query = default,
            int? limit = default,
            bool? includeTotalStorageSize = default,
            global::System.Collections.Generic.IList<string>? expandColumns = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}