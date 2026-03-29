//HintName: G.ISnapshotsClient.CreateFullSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Create storage snapshot<br/>
        /// Create new snapshot of the whole storage
        /// </summary>
        /// <param name="wait"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFullSnapshotResponse> CreateFullSnapshotAsync(
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}