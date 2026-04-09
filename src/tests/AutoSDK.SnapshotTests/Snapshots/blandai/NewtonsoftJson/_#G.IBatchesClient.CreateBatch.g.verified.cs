//HintName: G.IBatchesClient.CreateBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch of AI phone calls. Each call inherits global settings unless overridden per call object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataResponseBatchId> CreateBatchAsync(

            global::G.CreateBatchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch of AI phone calls. Each call inherits global settings unless overridden per call object.
        /// </summary>
        /// <param name="callObjects">
        /// List of individual call objects following the SendCall schema
        /// </param>
        /// <param name="global">
        /// Global properties applied to all calls unless overridden. Must include at least task or pathway_id. Must NOT include phone_number.
        /// </param>
        /// <param name="description">
        /// Short label for the batch (max 60 chars, shown in dashboard)<br/>
        /// Default Value: Untitled Batch
        /// </param>
        /// <param name="statusWebhook">
        /// URL receiving POST updates at each lifecycle phase
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataResponseBatchId> CreateBatchAsync(
            global::System.Collections.Generic.IList<global::G.CreateBatchRequestCallObject> callObjects,
            object global,
            string? description = default,
            string? statusWebhook = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}