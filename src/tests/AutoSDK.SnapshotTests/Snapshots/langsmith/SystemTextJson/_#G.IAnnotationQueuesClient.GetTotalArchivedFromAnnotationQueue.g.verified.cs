//HintName: G.IAnnotationQueuesClient.GetTotalArchivedFromAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Total Archived From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueueSizeSchema> GetTotalArchivedFromAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}