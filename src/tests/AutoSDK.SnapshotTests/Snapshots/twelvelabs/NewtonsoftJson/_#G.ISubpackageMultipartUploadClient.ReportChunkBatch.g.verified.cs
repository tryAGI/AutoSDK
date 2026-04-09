//HintName: G.ISubpackageMultipartUploadClient.ReportChunkBatch.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// Report uploaded chunks<br/>
        /// This method reports successfully uploaded chunks to the platform. The platform finalizes the upload after you report all chunks.<br/>
        /// For optimal performance, report chunks in batches and in any order.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReportChunkBatchResponse> ReportChunkBatchAsync(
            string uploadId,
            string xApiKey,

            global::G.ReportChunkBatchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Report uploaded chunks<br/>
        /// This method reports successfully uploaded chunks to the platform. The platform finalizes the upload after you report all chunks.<br/>
        /// For optimal performance, report chunks in batches and in any order.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="completedChunks">
        /// The list of chunks successfully uploaded that you're reporting to the platform. Report only after receiving an ETag.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReportChunkBatchResponse> ReportChunkBatchAsync(
            string uploadId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::G.CompletedChunk> completedChunks,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}