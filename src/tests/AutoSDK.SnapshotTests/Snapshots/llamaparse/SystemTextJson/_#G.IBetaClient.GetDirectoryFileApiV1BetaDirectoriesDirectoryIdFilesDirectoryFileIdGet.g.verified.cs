//HintName: G.IBetaClient.GetDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Directory File<br/>
        /// Get a file by its directory_file_id within the specified directory. If you're trying to get a file by its unique_id, use the list endpoint with a filter instead.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> GetDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdGetAsync(
            string directoryId,
            string directoryFileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}