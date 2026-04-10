//HintName: G.IBetaClient.ListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Batch Job Items<br/>
        /// List items in a batch job with optional status filtering.<br/>
        /// Useful for finding failed items, viewing completed items,<br/>
        /// or debugging processing issues.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status">
        /// Filter items by status
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Number of items to skip<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchItemListResponse> ListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetAsync(
            string jobId,
            global::G.BatchFileStatus? status = default,
            int? limit = default,
            int? offset = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}