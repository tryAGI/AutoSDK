//HintName: G.ISandboxesClient.CreateSandboxesBySandboxIDSnapshots.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a persistent snapshot from the sandbox's current state. Snapshots can be used to create new sandboxes and persist beyond the original sandbox's lifetime.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SnapshotInfo> CreateSandboxesBySandboxIDSnapshotsAsync(
            string sandboxID,

            global::G.CreateSandboxesSnapshotsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a persistent snapshot from the sandbox's current state. Snapshots can be used to create new sandboxes and persist beyond the original sandbox's lifetime.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="name">
        /// Optional name for the snapshot template. If a snapshot template with this name already exists, a new build will be assigned to the existing template instead of creating a new one.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SnapshotInfo> CreateSandboxesBySandboxIDSnapshotsAsync(
            string sandboxID,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}