//HintName: G.IDependencyGraphClient.DependencyGraphCreateRepositorySnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface IDependencyGraphClient
    {
        /// <summary>
        /// Create a snapshot of dependencies for a repository<br/>
        /// Create a new snapshot of a repository's dependencies.<br/>
        /// The authenticated user must have access to the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DependencyGraphCreateRepositorySnapshotResponse> DependencyGraphCreateRepositorySnapshotAsync(
            string owner,
            string repo,
            global::G.Snapshot request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a snapshot of dependencies for a repository<br/>
        /// Create a new snapshot of a repository's dependencies.<br/>
        /// The authenticated user must have access to the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="version">
        /// The version of the repository snapshot submission.
        /// </param>
        /// <param name="job"></param>
        /// <param name="sha">
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.<br/>
        /// Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </param>
        /// <param name="ref">
        /// The repository branch that triggered this snapshot.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="detector">
        /// A description of the detector used.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="manifests">
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </param>
        /// <param name="scanned">
        /// The time at which the snapshot was scanned.<br/>
        /// Example: 2020-06-13T14:52:50-05:00
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DependencyGraphCreateRepositorySnapshotResponse> DependencyGraphCreateRepositorySnapshotAsync(
            string owner,
            string repo,
            int version,
            global::G.SnapshotJob job,
            string sha,
            string @ref,
            global::G.SnapshotDetector detector,
            global::System.DateTime scanned,
            global::System.Collections.Generic.Dictionary<string, global::G.AnyOf<string, double?, bool?>?>? metadata = default,
            global::System.Collections.Generic.Dictionary<string, global::G.Manifest>? manifests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}