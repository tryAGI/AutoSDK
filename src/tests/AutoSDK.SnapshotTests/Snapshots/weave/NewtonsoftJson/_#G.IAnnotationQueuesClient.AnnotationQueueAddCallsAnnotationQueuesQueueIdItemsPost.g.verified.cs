//HintName: G.IAnnotationQueuesClient.AnnotationQueueAddCallsAnnotationQueuesQueueIdItemsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Add Calls<br/>
        /// Add calls to an annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueAddCallsRes> AnnotationQueueAddCallsAnnotationQueuesQueueIdItemsPostAsync(
            string queueId,

            global::G.AnnotationQueueAddCallsBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Add Calls<br/>
        /// Add calls to an annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="callIds"></param>
        /// <param name="displayFields">
        /// JSON paths to display to annotators
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueAddCallsRes> AnnotationQueueAddCallsAnnotationQueuesQueueIdItemsPostAsync(
            string queueId,
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            global::System.Collections.Generic.IList<string> displayFields,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}