﻿//HintName: G.IProjectsClient.EditProjectsByProjectIdChaptersByChapterId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Edit Chapter<br/>
        /// Edits a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.EditChapterResponseModel> EditProjectsByProjectIdChaptersByChapterIdAsync(
            string projectId,
            string chapterId,
            global::G.BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit Chapter<br/>
        /// Edits a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name of the chapter, used for identification only.<br/>
        /// Example: Chapter 1
        /// </param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.EditChapterResponseModel> EditProjectsByProjectIdChaptersByChapterIdAsync(
            string projectId,
            string chapterId,
            string? xiApiKey = default,
            string? name = default,
            global::G.ChapterContentInputModel? content = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}