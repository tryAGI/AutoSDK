//HintName: G.IAnnotationQueuesClient.AnnotationQueueReadAnnotationQueuesQueueIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Read<br/>
        /// Read a specific annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueReadRes> AnnotationQueueReadAnnotationQueuesQueueIdGetAsync(
            string queueId,
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}