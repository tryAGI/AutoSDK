//HintName: G.IAnnotationQueuesClient.AnnotationQueuesListQueueItems.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get items for a specific annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedAnnotationQueueItems> AnnotationQueuesListQueueItemsAsync(
            string queueId,
            global::G.AnnotationQueueStatus? status = default,
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}