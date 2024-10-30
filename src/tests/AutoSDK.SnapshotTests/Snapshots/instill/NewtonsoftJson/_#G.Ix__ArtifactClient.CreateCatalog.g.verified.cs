//HintName: G.Ix__ArtifactClient.CreateCatalog.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// Create a catalog<br/>
        /// Creates a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCatalogResponse> CreateCatalogAsync(
            string namespaceId,
            global::G.CreateCatalogBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a catalog<br/>
        /// Creates a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="name">
        /// The catalog name.
        /// </param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCatalogResponse> CreateCatalogAsync(
            string namespaceId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}