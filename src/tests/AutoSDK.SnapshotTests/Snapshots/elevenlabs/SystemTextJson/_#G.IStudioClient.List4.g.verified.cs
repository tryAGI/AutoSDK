//HintName: G.IStudioClient.List4.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// List Chapter Snapshots<br/>
        /// Gets information about all the snapshots of a chapter. Each snapshot can be downloaded as audio. Whenever a chapter is converted a snapshot will automatically be created.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChapterSnapshotsResponseModel> List4Async(
            string projectId,
            string chapterId,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}