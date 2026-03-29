//HintName: G.IStorageLocalClient.Sync.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageLocalClient
    {
        /// <summary>
        /// Sync export storage<br/>
        /// Sync tasks from a local file export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalFilesExportStorage> SyncAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}