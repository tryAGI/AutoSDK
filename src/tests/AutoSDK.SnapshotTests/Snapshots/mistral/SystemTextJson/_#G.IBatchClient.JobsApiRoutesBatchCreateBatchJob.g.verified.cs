//HintName: G.IBatchClient.JobsApiRoutesBatchCreateBatchJob.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobOut> JobsApiRoutesBatchCreateBatchJobAsync(
            global::G.BatchJobIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="timeoutHours">
        /// Default Value: 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobOut> JobsApiRoutesBatchCreateBatchJobAsync(
            global::G.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string model,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            int? timeoutHours = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}