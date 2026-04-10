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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobOut> JobsApiRoutesBatchCreateBatchJobAsync(

            global::G.BatchJobIn request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="inputFiles"></param>
        /// <param name="endpoint"></param>
        /// <param name="model"></param>
        /// <param name="metadata"></param>
        /// <param name="timeoutHours">
        /// Default Value: 24
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobOut> JobsApiRoutesBatchCreateBatchJobAsync(
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            global::G.ApiEndpoint endpoint,
            string model,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            int? timeoutHours = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}