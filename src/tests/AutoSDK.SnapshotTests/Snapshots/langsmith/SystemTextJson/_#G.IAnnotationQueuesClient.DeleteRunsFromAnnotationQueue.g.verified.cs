//HintName: G.IAnnotationQueuesClient.DeleteRunsFromAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Delete Runs From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsFromAnnotationQueueAsync(
            global::System.Guid queueId,
            global::G.AnnotationQueueBulkDeleteRunsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Runs From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="deleteAll">
        /// Default Value: false
        /// </param>
        /// <param name="runIds"></param>
        /// <param name="excludeRunIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsFromAnnotationQueueAsync(
            global::System.Guid queueId,
            bool? deleteAll = default,
            global::System.Collections.Generic.IList<global::System.Guid>? runIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludeRunIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}