//HintName: G.ICatalogClient.ListCatalogs.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Get all catalogs info
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCatalogsResponse> ListCatalogsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}