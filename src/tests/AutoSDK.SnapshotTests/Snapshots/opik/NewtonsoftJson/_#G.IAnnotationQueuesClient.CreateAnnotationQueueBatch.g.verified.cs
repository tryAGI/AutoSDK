//HintName: G.IAnnotationQueuesClient.CreateAnnotationQueueBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create annotation queue batch<br/>
        /// Create multiple annotation queues for human annotation workflows
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueBatchAsync(

            global::G.AnnotationQueueBatchWrite request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue batch<br/>
        /// Create multiple annotation queues for human annotation workflows
        /// </summary>
        /// <param name="annotationQueues">
        /// List of annotation queues to create
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueBatchAsync(
            global::System.Collections.Generic.IList<global::G.AnnotationQueueWrite> annotationQueues,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}