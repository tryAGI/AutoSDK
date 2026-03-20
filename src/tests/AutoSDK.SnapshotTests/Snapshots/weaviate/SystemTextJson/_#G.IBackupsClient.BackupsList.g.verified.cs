//HintName: G.IBackupsClient.BackupsList.g.cs
#nullable enable

namespace G
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// List backups in progress<br/>
        /// List all backups in progress
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BackupListResponseItem>> BackupsListAsync(
            string backend,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}