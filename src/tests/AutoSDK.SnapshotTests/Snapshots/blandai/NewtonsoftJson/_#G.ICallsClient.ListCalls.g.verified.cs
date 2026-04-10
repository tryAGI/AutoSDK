//HintName: G.ICallsClient.ListCalls.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// List Calls<br/>
        /// Returns metadata for calls dispatched by your account.
        /// </summary>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="ascending">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="completed"></param>
        /// <param name="batchId"></param>
        /// <param name="answeredBy"></param>
        /// <param name="inbound"></param>
        /// <param name="campaignId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCallsResponse> ListCallsAsync(
            string? fromNumber = default,
            string? toNumber = default,
            int? from = default,
            int? to = default,
            int? limit = default,
            bool? ascending = default,
            global::G.ListCallsSortBy? sortBy = default,
            string? startDate = default,
            string? endDate = default,
            bool? completed = default,
            string? batchId = default,
            string? answeredBy = default,
            bool? inbound = default,
            string? campaignId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}