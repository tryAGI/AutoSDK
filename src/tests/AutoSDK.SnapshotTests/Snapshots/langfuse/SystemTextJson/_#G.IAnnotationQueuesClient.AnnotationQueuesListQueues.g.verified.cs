//HintName: G.IAnnotationQueuesClient.AnnotationQueuesListQueues.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get all annotation queues
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedAnnotationQueues> AnnotationQueuesListQueuesAsync(
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}