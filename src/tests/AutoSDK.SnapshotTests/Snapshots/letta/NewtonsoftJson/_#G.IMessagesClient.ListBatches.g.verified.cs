//HintName: G.IMessagesClient.ListBatches.g.cs
#nullable enable

namespace G
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// List Batches<br/>
        /// List all batch runs.
        /// </summary>
        /// <param name="before">
        /// Job ID cursor for pagination. Returns jobs that come before this job ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Job ID cursor for pagination. Returns jobs that come after this job ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of jobs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for jobs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BatchJob>> ListBatchesAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListBatchesOrder? order = default,
            string? orderBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}