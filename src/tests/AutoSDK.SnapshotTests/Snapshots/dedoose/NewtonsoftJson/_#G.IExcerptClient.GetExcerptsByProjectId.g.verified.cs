//HintName: G.IExcerptClient.GetExcerptsByProjectId.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// GetExcerptsByProjectId<br/>
        /// GetExcerptsByProjectId
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> GetExcerptsByProjectIdAsync(

            global::G.GetExcerptsByProjectIdRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GetExcerptsByProjectId<br/>
        /// GetExcerptsByProjectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> GetExcerptsByProjectIdAsync(
            global::System.Guid projectId,
            int page,
            int pageSize,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}