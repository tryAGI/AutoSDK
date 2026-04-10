//HintName: G.IAnnotationQueuesClient.AnnotationQueuesCreateQueueItem.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Add an item to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueItem> AnnotationQueuesCreateQueueItemAsync(
            string queueId,

            global::G.CreateAnnotationQueueItemRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add an item to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="objectId"></param>
        /// <param name="objectType"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueItem> AnnotationQueuesCreateQueueItemAsync(
            string queueId,
            string objectId,
            global::G.AnnotationQueueObjectType objectType,
            global::G.AnnotationQueueStatus? status = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}