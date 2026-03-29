//HintName: G.IDatasetsClient.RestoreDatasetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Restore dataset to a previous version<br/>
        /// Restores the dataset to a previous version state by creating a new version with items copied from the specified version. If the version is already the latest, returns it as-is (no-op).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionPublic> RestoreDatasetVersionAsync(
            global::System.Guid id,

            global::G.DatasetVersionRestorePublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore dataset to a previous version<br/>
        /// Restores the dataset to a previous version state by creating a new version with items copied from the specified version. If the version is already the latest, returns it as-is (no-op).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionRef">
        /// Version hash or tag to restore from
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionPublic> RestoreDatasetVersionAsync(
            global::System.Guid id,
            string versionRef,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}