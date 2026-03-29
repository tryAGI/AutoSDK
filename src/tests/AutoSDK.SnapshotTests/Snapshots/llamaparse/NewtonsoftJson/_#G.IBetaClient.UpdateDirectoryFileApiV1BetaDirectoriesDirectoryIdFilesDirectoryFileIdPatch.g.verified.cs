//HintName: G.IBetaClient.UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Directory File<br/>
        /// Update file metadata within the specified directory.<br/>
        /// Supports moving files to a different directory by setting directory_id.<br/>
        /// Note: This endpoint uses directory_file_id (the internal ID). If you're trying to update a file by its unique_id, use the list endpoint with a filter to find the directory_file_id first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
            string directoryId,
            string directoryFileId,

            global::G.DirectoryFileUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Directory File<br/>
        /// Update file metadata within the specified directory.<br/>
        /// Supports moving files to a different directory by setting directory_id.<br/>
        /// Note: This endpoint uses directory_file_id (the internal ID). If you're trying to update a file by its unique_id, use the list endpoint with a filter to find the directory_file_id first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uniqueId">
        /// Updated unique identifier.
        /// </param>
        /// <param name="displayName">
        /// Updated display name.
        /// </param>
        /// <param name="requestDirectoryId">
        /// Move file to a different directory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
            string directoryId,
            string directoryFileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? requestDirectoryId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}