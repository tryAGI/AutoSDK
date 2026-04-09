//HintName: G.IAnnotationQueuesClient.AnnotationQueuesQueryStreamAnnotationQueuesQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queues Query Stream<br/>
        /// Query annotation queues for a project (streaming NDJSON response).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnnotationQueuesQueryStreamAnnotationQueuesQueryPostAsync(

            global::G.AnnotationQueuesQueryReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queues Query Stream<br/>
        /// Query annotation queues for a project (streaming NDJSON response).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Filter by queue name (case-insensitive partial match)
        /// </param>
        /// <param name="sortBy">
        /// Sort by multiple fields (e.g., created_at, updated_at, name)
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AnnotationQueuesQueryStreamAnnotationQueuesQueryPostAsync(
            string projectId,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}