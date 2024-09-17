//HintName: G.ICatalogClient.DeleteCatalogFile.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Delete a file
        /// </summary>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteCatalogFileResponse> DeleteCatalogFileAsync(
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}