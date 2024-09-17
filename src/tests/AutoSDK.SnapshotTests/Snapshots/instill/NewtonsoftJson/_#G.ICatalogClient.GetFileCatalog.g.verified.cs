//HintName: G.ICatalogClient.GetFileCatalog.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Get file catalog
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileId"></param>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFileCatalogResponse> GetFileCatalogAsync(
            string namespaceId,
            string catalogId,
            string? fileId = default,
            string? fileUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}