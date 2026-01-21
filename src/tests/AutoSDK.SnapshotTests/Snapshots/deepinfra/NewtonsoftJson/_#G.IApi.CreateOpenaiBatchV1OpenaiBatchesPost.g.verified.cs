//HintName: G.IApi.CreateOpenaiBatchV1OpenaiBatchesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create Openai Batch
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIBatch> CreateOpenaiBatchV1OpenaiBatchesPostAsync(
            global::G.OpenAIBatchesIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Openai Batch
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently /v1/chat/completions, /v1/completions are supported.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Currently only 24h is supported.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to be stored with the batch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIBatch> CreateOpenaiBatchV1OpenaiBatchesPostAsync(
            string inputFileId,
            global::G.OpenAIBatchesInEndpoint endpoint,
            string completionWindow,
            object? metadata,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}