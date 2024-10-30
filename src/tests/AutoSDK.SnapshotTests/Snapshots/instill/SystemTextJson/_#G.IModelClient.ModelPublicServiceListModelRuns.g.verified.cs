//HintName: G.IModelClient.ModelPublicServiceListModelRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List model runs<br/>
        /// Returns a paginated list of model runs.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="orderBy"></param>
        /// <param name="filter"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelRunsResponse> ModelPublicServiceListModelRunsAsync(
            string namespaceId,
            string modelId,
            int? pageSize = default,
            int? page = default,
            string? orderBy = default,
            string? filter = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}