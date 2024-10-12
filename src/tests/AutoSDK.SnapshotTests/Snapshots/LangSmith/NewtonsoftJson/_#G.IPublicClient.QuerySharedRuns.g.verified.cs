//HintName: G.IPublicClient.QuerySharedRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Query Shared Runs<br/>
        /// Get run by ids or the shared run if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPublicRunsResponse> QuerySharedRunsAsync(
            global::System.Guid shareToken,
            global::G.QueryParamsForPublicRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Query Shared Runs<br/>
        /// Get run by ids or the shared run if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPublicRunsResponse> QuerySharedRunsAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}