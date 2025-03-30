//HintName: G.IStudioClient.GetStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotId.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Get Chapter Snapshot<br/>
        /// Returns the chapter snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The ID of the chapter snapshot.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChapterSnapshotExtendedResponseModel> GetStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdAsync(
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}