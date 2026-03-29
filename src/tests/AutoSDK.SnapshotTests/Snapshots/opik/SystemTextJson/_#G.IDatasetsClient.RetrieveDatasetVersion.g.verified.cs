//HintName: G.IDatasetsClient.RetrieveDatasetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Retrieve dataset version by name<br/>
        /// Get a specific version by its version name (e.g., 'v1', 'v373'). This is more efficient than paginating through all versions for large datasets.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionPublic> RetrieveDatasetVersionAsync(
            global::System.Guid id,

            global::G.DatasetVersionRetrieveRequestPublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve dataset version by name<br/>
        /// Get a specific version by its version name (e.g., 'v1', 'v373'). This is more efficient than paginating through all versions for large datasets.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionName">
        /// Version name in format 'vN' (e.g., 'v1', 'v373')<br/>
        /// Example: v1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionPublic> RetrieveDatasetVersionAsync(
            global::System.Guid id,
            string versionName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}