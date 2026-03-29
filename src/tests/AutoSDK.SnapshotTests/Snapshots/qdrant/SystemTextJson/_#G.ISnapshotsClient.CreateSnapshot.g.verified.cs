//HintName: G.ISnapshotsClient.CreateSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Create collection snapshot<br/>
        /// Create new snapshot for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSnapshotResponse> CreateSnapshotAsync(
            string collectionName,
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}