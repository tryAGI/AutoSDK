//HintName: G.IBetaClient.BulkDeleteDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesBulkDeletePost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Bulk Delete Directory Files<br/>
        /// Delete multiple files from the specified directory.<br/>
        /// All files must belong to the specified directory. Maximum 100 files per request.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task BulkDeleteDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesBulkDeletePostAsync(
            string directoryId,

            global::G.DirectoryFileBulkDeleteRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Delete Directory Files<br/>
        /// Delete multiple files from the specified directory.<br/>
        /// All files must belong to the specified directory. Maximum 100 files per request.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="directoryFileIds">
        /// List of directory file IDs to delete (max 100).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BulkDeleteDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesBulkDeletePostAsync(
            string directoryId,
            global::System.Collections.Generic.IList<string> directoryFileIds,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}