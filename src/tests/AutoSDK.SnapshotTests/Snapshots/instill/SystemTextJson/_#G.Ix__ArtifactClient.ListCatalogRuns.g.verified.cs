//HintName: G.Ix__ArtifactClient.ListCatalogRuns.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// List Catalog Runs<br/>
        /// Returns a paginated list of catalog runs.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCatalogRunsResponse> ListCatalogRunsAsync(
            string namespaceId,
            string catalogId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}