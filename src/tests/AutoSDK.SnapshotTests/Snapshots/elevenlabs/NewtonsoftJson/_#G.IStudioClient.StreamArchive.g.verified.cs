//HintName: G.IStudioClient.StreamArchive.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Stream Archive With Studio Project Audio<br/>
        /// Returns a compressed archive of the Studio project's audio.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The ID of the Studio project snapshot.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamArchiveAsync(
            string projectId,
            string projectSnapshotId,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}