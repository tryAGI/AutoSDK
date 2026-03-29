//HintName: G.ICollectionsClient.GetCollections.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// List collections<br/>
        /// Lists all collections in the specified workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCollectionsResponse> GetCollectionsAsync(
            string workspaceId,
            int? currentPage = default,
            int? pageSize = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}