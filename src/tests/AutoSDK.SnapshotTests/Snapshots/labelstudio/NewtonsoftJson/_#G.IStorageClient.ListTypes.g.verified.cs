//HintName: G.IStorageClient.ListTypes.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all export storages types<br/>
        /// Retrieve a list of the export storages types.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiStoragesExportTypesRetrieveResponseItem>> ListTypesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}