//HintName: G.IAnnotationQueuesClient.FindAnnotationQueues.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Find annotation queues<br/>
        /// Find annotation queues with filtering and sorting
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter annotation queues by name (partial match, case insensitive)
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotationQueuePagePublic> FindAnnotationQueuesAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? filters = default,
            string? sorting = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}