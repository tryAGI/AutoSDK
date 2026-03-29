//HintName: G.IMessagesClient.CreateBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Create Batch<br/>
        /// Submit a batch of agent runs for asynchronous processing.<br/>
        /// Creates a job that will fan out messages to all listed agents and process them in parallel.<br/>
        /// The request will be rejected if it exceeds 256MB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJob> CreateBatchAsync(

            global::G.CreateBatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Submit a batch of agent runs for asynchronous processing.<br/>
        /// Creates a job that will fan out messages to all listed agents and process them in parallel.<br/>
        /// The request will be rejected if it exceeds 256MB.
        /// </summary>
        /// <param name="requests">
        /// List of requests to be processed in batch.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional URL to call via POST when the batch completes. The callback payload will be a JSON object with the following fields: {'job_id': string, 'status': string, 'completed_at': string}. Where 'job_id' is the unique batch job identifier, 'status' is the final batch status (e.g., 'completed', 'failed'), and 'completed_at' is an ISO 8601 timestamp indicating when the batch job completed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJob> CreateBatchAsync(
            global::System.Collections.Generic.IList<global::G.LettaBatchRequest> requests,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}