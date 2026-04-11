//HintName: G.IBatchClient.CreateBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests. [Learn more](/docs/batch).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Batch> CreateBatchAsync(

            global::G.CreateBatchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests. [Learn more](/docs/batch).
        /// </summary>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](/docs/api-reference#files-upload) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](/docs/batch), and must be uploaded with the purpose `batch`. The file can be up to 100 MB in size.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` is supported.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Durations from `24h` to `7d` are supported.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata for the batch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Batch> CreateBatchAsync(
            string inputFileId,
            string completionWindow,
            global::G.CreateBatchRequestEndpoint endpoint = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}