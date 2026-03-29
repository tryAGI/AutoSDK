//HintName: G.IAnnotationQueuesClient.AnnotationQueuesStatsAnnotationQueuesStatsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queues Stats<br/>
        /// Get stats for multiple annotation queues.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueuesStatsRes> AnnotationQueuesStatsAnnotationQueuesStatsPostAsync(

            global::G.AnnotationQueuesStatsReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queues Stats<br/>
        /// Get stats for multiple annotation queues.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="queueIds">
        /// List of queue IDs to get stats for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueuesStatsRes> AnnotationQueuesStatsAnnotationQueuesStatsPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> queueIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}