//HintName: G.IBetaClient.AddDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Add Directory File<br/>
        /// Create a new file within the specified directory.<br/>
        /// The directory must exist and belong to the project passed in.<br/>
        /// The file_id must be provided and exist in the project.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> AddDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesPostAsync(
            string directoryId,

            global::G.DirectoryFileCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Directory File<br/>
        /// Create a new file within the specified directory.<br/>
        /// The directory must exist and belong to the project passed in.<br/>
        /// The file_id must be provided and exist in the project.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="fileId">
        /// File ID for the storage location (required).
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for the file in the directory. If not provided, will use the file's external_file_id or name.
        /// </param>
        /// <param name="displayName">
        /// Display name for the file. If not provided, will use the file's name.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> AddDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesPostAsync(
            string directoryId,
            string fileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}