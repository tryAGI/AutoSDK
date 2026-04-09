//HintName: G.ISnapshotsClient.ListSnapshots.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// List collection snapshots<br/>
        /// Get list of snapshots for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListSnapshotsResponse> ListSnapshotsAsync(
            string collectionName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}