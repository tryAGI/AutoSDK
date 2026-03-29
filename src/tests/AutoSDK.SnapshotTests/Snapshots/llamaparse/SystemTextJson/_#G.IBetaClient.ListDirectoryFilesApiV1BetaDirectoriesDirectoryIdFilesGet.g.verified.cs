//HintName: G.IBetaClient.ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Directory Files<br/>
        /// List all files within the specified directory with optional filtering and pagination.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="displayName"></param>
        /// <param name="displayNameContains"></param>
        /// <param name="uniqueId"></param>
        /// <param name="fileId"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileQueryResponse> ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync(
            string directoryId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? displayName = default,
            string? displayNameContains = default,
            string? uniqueId = default,
            string? fileId = default,
            bool? includeDeleted = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}