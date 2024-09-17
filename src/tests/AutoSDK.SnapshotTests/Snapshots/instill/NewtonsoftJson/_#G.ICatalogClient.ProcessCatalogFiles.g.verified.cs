//HintName: G.ICatalogClient.ProcessCatalogFiles.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Process catalog files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::G.ProcessCatalogFilesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Process catalog files
        /// </summary>
        /// <param name="fileUids">
        /// The file uid.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::System.Collections.Generic.IList<string> fileUids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}