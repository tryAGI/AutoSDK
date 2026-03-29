//HintName: G.IAnnotationQueuesClient.RemoveItemsFromAnnotationQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Remove items from annotation queue<br/>
        /// Remove items from annotation queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveItemsFromAnnotationQueueAsync(
            global::System.Guid id,

            global::G.AnnotationQueueItemIds request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove items from annotation queue<br/>
        /// Remove items from annotation queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RemoveItemsFromAnnotationQueueAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}