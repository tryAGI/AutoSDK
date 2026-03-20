//HintName: G.IAnnotationQueuesClient.DeleteAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Delete Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}