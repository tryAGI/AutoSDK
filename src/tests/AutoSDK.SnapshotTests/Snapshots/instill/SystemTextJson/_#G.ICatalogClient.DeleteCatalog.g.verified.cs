//HintName: G.ICatalogClient.DeleteCatalog.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Delete a catalog
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteCatalogResponse> DeleteCatalogAsync(
            string namespaceId,
            string catalogId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}