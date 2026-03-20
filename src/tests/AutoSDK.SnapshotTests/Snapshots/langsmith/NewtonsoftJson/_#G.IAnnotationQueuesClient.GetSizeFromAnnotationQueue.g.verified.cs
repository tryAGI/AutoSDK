//HintName: G.IAnnotationQueuesClient.GetSizeFromAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Size From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueSizeSchema> GetSizeFromAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}