//HintName: G.IDatasetsClient.CreateVersionTag.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create version tag<br/>
        /// Add a tag to a specific dataset version for easy reference (e.g., 'baseline', 'v1.0', 'production')
        /// </summary>
        /// <param name="versionHash"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVersionTagAsync(
            string versionHash,
            global::System.Guid id,

            global::G.DatasetVersionTag request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create version tag<br/>
        /// Add a tag to a specific dataset version for easy reference (e.g., 'baseline', 'v1.0', 'production')
        /// </summary>
        /// <param name="versionHash"></param>
        /// <param name="id"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVersionTagAsync(
            string versionHash,
            global::System.Guid id,
            string tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}