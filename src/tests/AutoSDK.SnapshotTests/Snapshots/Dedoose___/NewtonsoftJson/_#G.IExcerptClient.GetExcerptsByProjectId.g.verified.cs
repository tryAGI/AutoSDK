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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> GetExcerptsByProjectIdAsync(
            global::G.GetExcerptsByProjectIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExcerptsByProjectId<br/>
        /// GetExcerptsByProjectId
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> GetExcerptsByProjectIdAsync(
            global::System.Guid projectId,
            int page,
            int pageSize,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}