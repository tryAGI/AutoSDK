//HintName: G.IBetaClient.DeleteDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Directory File<br/>
        /// Delete a file from the specified directory.<br/>
        /// Note: This endpoint uses directory_file_id (the internal ID). If you're trying to delete a file by its unique_id, use the list endpoint with a filter to find the directory_file_id first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdDeleteAsync(
            string directoryId,
            string directoryFileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}