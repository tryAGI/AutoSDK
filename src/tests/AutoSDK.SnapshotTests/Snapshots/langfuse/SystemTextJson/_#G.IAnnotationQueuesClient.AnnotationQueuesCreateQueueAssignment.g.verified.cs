//HintName: G.IAnnotationQueuesClient.AnnotationQueuesCreateQueueAssignment.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create an assignment for a user to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAnnotationQueueAssignmentResponse> AnnotationQueuesCreateQueueAssignmentAsync(
            string queueId,

            global::G.AnnotationQueueAssignmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an assignment for a user to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAnnotationQueueAssignmentResponse> AnnotationQueuesCreateQueueAssignmentAsync(
            string queueId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}