//HintName: G.ISnapshotsClient.DeleteFullSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Delete storage snapshot<br/>
        /// Delete snapshot of the whole storage
        /// </summary>
        /// <param name="snapshotName"></param>
        /// <param name="wait"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFullSnapshotResponse> DeleteFullSnapshotAsync(
            string snapshotName,
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}