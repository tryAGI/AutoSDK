//HintName: G.IAnnotationQueuesClient.GetRunFromAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunSchemaWithAnnotationQueueInfo> GetRunFromAnnotationQueueAsync(
            global::System.Guid queueId,
            int index,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}