//HintName: G.IBetaClient.UpdateDirectoryApiV1BetaDirectoriesDirectoryIdPatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Directory<br/>
        /// Update directory metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryResponse> UpdateDirectoryApiV1BetaDirectoriesDirectoryIdPatchAsync(
            string directoryId,

            global::G.DirectoryUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Directory<br/>
        /// Update directory metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Updated name for the directory.
        /// </param>
        /// <param name="description">
        /// Updated description for the directory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryResponse> UpdateDirectoryApiV1BetaDirectoriesDirectoryIdPatchAsync(
            string directoryId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}