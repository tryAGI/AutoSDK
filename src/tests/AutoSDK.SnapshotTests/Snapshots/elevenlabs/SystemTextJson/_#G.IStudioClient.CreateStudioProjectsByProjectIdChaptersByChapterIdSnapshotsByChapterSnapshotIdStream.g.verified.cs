//HintName: G.IStudioClient.CreateStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStream.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/studio/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the snapshots of a chapter.
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            global::G.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/studio/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the snapshots of a chapter.
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
        /// <param name="convertToMpeg">
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            string? xiApiKey = default,
            bool? convertToMpeg = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}