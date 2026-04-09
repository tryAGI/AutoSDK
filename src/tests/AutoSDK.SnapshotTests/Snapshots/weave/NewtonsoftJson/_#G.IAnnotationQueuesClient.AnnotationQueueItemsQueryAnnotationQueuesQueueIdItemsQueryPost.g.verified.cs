//HintName: G.IAnnotationQueuesClient.AnnotationQueueItemsQueryAnnotationQueuesQueueIdItemsQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Items Query<br/>
        /// Query items in an annotation queue with pagination and sorting.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueItemsQueryRes> AnnotationQueueItemsQueryAnnotationQueuesQueueIdItemsQueryPostAsync(
            string queueId,

            global::G.AnnotationQueueItemsQueryBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Items Query<br/>
        /// Query items in an annotation queue with pagination and sorting.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="filter">
        /// Filter queue items by call metadata and annotation state
        /// </param>
        /// <param name="sortBy">
        /// Sort by multiple fields (e.g., created_at, updated_at)
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="includePosition">
        /// Include position_in_queue field (1-based index in full queue)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueItemsQueryRes> AnnotationQueueItemsQueryAnnotationQueuesQueueIdItemsQueryPostAsync(
            string queueId,
            string projectId,
            global::G.AnnotationQueueItemsFilter? filter = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            bool? includePosition = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}