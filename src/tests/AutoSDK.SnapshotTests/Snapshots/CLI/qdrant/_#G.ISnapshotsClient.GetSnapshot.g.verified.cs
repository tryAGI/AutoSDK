//HintName: G.ISnapshotsClient.GetSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Download collection snapshot<br/>
        /// Download specified snapshot from a collection as a file
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="snapshotName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetSnapshotAsync(
            string collectionName,
            string snapshotName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}