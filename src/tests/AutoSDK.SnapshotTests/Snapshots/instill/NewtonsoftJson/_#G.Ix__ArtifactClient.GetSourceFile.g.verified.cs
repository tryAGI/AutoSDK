//HintName: G.Ix__ArtifactClient.GetSourceFile.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// Get catalog single-source-of-truth file<br/>
        /// Gets the single-source-of-truth file of a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSourceFileResponse> GetSourceFileAsync(
            string namespaceId,
            string catalogId,
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}