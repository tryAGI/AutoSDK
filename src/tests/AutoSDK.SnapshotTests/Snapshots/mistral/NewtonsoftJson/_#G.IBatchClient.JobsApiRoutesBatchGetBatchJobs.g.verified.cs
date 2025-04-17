//HintName: G.IBatchClient.JobsApiRoutesBatchGetBatchJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Jobs<br/>
        /// Get a list of batch jobs for your organization and user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobsOut> JobsApiRoutesBatchGetBatchJobsAsync(
            int? page = default,
            int? pageSize = default,
            string? model = default,
            object? metadata = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = default,
            global::System.Collections.Generic.IList<global::G.BatchJobStatus>? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}