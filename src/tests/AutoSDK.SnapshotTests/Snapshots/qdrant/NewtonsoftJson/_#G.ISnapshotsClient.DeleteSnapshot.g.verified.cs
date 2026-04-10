//HintName: G.ISnapshotsClient.DeleteSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Delete collection snapshot<br/>
        /// Delete snapshot for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="snapshotName"></param>
        /// <param name="wait"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteSnapshotResponse> DeleteSnapshotAsync(
            string collectionName,
            string snapshotName,
            bool? wait = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}