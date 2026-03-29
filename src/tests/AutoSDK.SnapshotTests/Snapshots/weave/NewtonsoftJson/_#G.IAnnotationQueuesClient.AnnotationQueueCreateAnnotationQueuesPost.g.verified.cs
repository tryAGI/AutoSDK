//HintName: G.IAnnotationQueuesClient.AnnotationQueueCreateAnnotationQueuesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Create<br/>
        /// Create a new annotation queue.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueCreateRes> AnnotationQueueCreateAnnotationQueuesPostAsync(

            global::G.AnnotationQueueCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Create<br/>
        /// Create a new annotation queue.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scorerRefs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueCreateRes> AnnotationQueueCreateAnnotationQueuesPostAsync(
            string projectId,
            string name,
            global::System.Collections.Generic.IList<string> scorerRefs,
            string? description = default,
            string? wbUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}