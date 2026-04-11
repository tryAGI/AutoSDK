//HintName: G.IAnnotationQueuesClient.CreateAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create annotation queue<br/>
        /// Create annotation queue for human annotation workflows
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueAsync(

            global::G.AnnotationQueueWrite request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue<br/>
        /// Create annotation queue for human annotation workflows
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="scope"></param>
        /// <param name="commentsEnabled"></param>
        /// <param name="feedbackDefinitionNames"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueAsync(
            global::System.Guid projectId,
            string name,
            global::G.AnnotationQueueWriteScope scope,
            global::System.Guid? id = default,
            string? description = default,
            string? instructions = default,
            bool? commentsEnabled = default,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}