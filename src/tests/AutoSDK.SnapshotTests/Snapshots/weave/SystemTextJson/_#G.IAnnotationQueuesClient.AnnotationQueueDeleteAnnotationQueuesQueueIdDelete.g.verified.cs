//HintName: G.IAnnotationQueuesClient.AnnotationQueueDeleteAnnotationQueuesQueueIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Delete<br/>
        /// Delete (soft-delete) an annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueDeleteRes> AnnotationQueueDeleteAnnotationQueuesQueueIdDeleteAsync(
            string queueId,
            string projectId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}