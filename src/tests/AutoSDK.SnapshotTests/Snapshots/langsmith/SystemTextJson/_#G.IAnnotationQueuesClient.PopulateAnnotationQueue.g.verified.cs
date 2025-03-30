//HintName: G.IAnnotationQueuesClient.PopulateAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Populate Annotation Queue<br/>
        /// Populate annotation queue with runs from an experiment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PopulateAnnotationQueueAsync(
            global::G.PopulateAnnotationQueueSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Populate Annotation Queue<br/>
        /// Populate annotation queue with runs from an experiment.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="sessionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PopulateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}