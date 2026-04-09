//HintName: G.IAnnotationQueuesClient.AnnotationQueuesDeleteQueueAssignment.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Delete an assignment for a user to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteAnnotationQueueAssignmentResponse> AnnotationQueuesDeleteQueueAssignmentAsync(
            string queueId,

            global::G.AnnotationQueueAssignmentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an assignment for a user to an annotation queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteAnnotationQueueAssignmentResponse> AnnotationQueuesDeleteQueueAssignmentAsync(
            string queueId,
            string userId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}