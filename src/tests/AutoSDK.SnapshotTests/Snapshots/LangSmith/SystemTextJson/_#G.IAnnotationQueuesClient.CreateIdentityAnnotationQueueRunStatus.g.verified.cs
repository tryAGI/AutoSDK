//HintName: G.IAnnotationQueuesClient.CreateIdentityAnnotationQueueRunStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse> CreateIdentityAnnotationQueueRunStatusAsync(
            global::System.Guid annotationQueueRunId,
            global::G.IdentityAnnotationQueueRunStatusCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="status"></param>
        /// <param name="overrideAddedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse> CreateIdentityAnnotationQueueRunStatusAsync(
            global::System.Guid annotationQueueRunId,
            string? status = default,
            global::System.DateTime? overrideAddedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}