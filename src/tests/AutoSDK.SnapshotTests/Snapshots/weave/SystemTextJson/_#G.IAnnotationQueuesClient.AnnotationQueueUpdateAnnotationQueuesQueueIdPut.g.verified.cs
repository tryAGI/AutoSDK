//HintName: G.IAnnotationQueuesClient.AnnotationQueueUpdateAnnotationQueuesQueueIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Update<br/>
        /// Update an annotation queue's metadata (name, description, scorer_refs).
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueUpdateRes> AnnotationQueueUpdateAnnotationQueuesQueueIdPutAsync(
            string queueId,

            global::G.AnnotationQueueUpdateBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Update<br/>
        /// Update an annotation queue's metadata (name, description, scorer_refs).
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scorerRefs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueUpdateRes> AnnotationQueueUpdateAnnotationQueuesQueueIdPutAsync(
            string queueId,
            string projectId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? scorerRefs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}