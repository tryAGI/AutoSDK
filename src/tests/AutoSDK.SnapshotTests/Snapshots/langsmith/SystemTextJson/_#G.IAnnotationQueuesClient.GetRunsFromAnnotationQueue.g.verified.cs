//HintName: G.IAnnotationQueuesClient.GetRunsFromAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Runs From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="archived"></param>
        /// <param name="includeStats"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RunSchemaWithAnnotationQueueInfo>> GetRunsFromAnnotationQueueAsync(
            global::System.Guid queueId,
            int? offset = default,
            int? limit = default,
            bool? archived = default,
            bool? includeStats = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}