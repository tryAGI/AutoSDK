//HintName: G.IBatchClient.ListBatchJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// List batch jobs<br/>
        /// List all batch inference jobs
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="status"></param>
        /// <param name="when"></param>
        /// <param name="timestampMs"></param>
        /// <param name="sortBy"></param>
        /// <param name="direction"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.InferenceJob>> ListBatchJobsAsync(
            int? limit = default,
            global::G.ListBatchJobsStatus? status = default,
            long? when = default,
            long? timestampMs = default,
            global::G.ListBatchJobsSortBy? sortBy = default,
            global::G.ListBatchJobsDirection? direction = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}