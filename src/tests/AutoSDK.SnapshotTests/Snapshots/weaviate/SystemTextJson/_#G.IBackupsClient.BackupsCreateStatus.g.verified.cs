//HintName: G.IBackupsClient.BackupsCreateStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Get backup process status<br/>
        /// Returns status of backup creation attempt for a set of collections. &lt;br/&gt;&lt;br/&gt;All client implementations have a `wait for completion` option which will poll the backup status in the background and only return once the backup has completed (successfully or unsuccessfully). If you set the `wait for completion` option to false, you can also check the status yourself using this endpoint.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BackupCreateStatusResponse> BackupsCreateStatusAsync(
            string backend,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}