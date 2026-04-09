//HintName: G.IAnnotationQueuesClient.AnnotationQueuesUpdateQueueItem.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update an annotation queue item
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueItem> AnnotationQueuesUpdateQueueItemAsync(
            string queueId,
            string itemId,

            global::G.UpdateAnnotationQueueItemRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an annotation queue item
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueItem> AnnotationQueuesUpdateQueueItemAsync(
            string queueId,
            string itemId,
            global::G.AnnotationQueueStatus? status = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}