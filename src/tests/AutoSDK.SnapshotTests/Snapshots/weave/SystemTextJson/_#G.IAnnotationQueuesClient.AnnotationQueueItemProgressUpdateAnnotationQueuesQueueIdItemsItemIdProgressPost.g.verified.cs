//HintName: G.IAnnotationQueuesClient.AnnotationQueueItemProgressUpdateAnnotationQueuesQueueIdItemsItemIdProgressPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Item Progress Update<br/>
        /// Update the annotation state of a queue item for the current annotator.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotatorQueueItemsProgressUpdateRes> AnnotationQueueItemProgressUpdateAnnotationQueuesQueueIdItemsItemIdProgressPostAsync(
            string queueId,
            string itemId,

            global::G.AnnotationQueueItemProgressUpdateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Item Progress Update<br/>
        /// Update the annotation state of a queue item for the current annotator.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="projectId"></param>
        /// <param name="annotationState">
        /// New state: 'in_progress', 'completed', or 'skipped'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotatorQueueItemsProgressUpdateRes> AnnotationQueueItemProgressUpdateAnnotationQueuesQueueIdItemsItemIdProgressPostAsync(
            string queueId,
            string itemId,
            string projectId,
            string annotationState,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}