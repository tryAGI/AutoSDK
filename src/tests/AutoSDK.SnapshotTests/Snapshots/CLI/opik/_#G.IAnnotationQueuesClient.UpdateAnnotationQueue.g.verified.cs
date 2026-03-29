//HintName: G.IAnnotationQueuesClient.UpdateAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update annotation queue<br/>
        /// Update annotation queue by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAnnotationQueueAsync(
            global::System.Guid id,

            global::G.AnnotationQueueUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update annotation queue<br/>
        /// Update annotation queue by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="commentsEnabled"></param>
        /// <param name="feedbackDefinitionNames"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateAnnotationQueueAsync(
            global::System.Guid id,
            string? name = default,
            string? description = default,
            string? instructions = default,
            bool? commentsEnabled = default,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}