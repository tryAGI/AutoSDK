//HintName: G.IAnnotationQueuesClient.AnnotationQueuesGetQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get an annotation queue by ID
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueue> AnnotationQueuesGetQueueAsync(
            string queueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}