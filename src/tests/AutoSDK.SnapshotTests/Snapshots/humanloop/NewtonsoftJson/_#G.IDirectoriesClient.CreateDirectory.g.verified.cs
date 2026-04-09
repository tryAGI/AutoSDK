//HintName: G.IDirectoriesClient.CreateDirectory.g.cs
#nullable enable

namespace G
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Create Directory
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryResponse> CreateDirectoryAsync(

            global::G.CreateDirectoryRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Directory
        /// </summary>
        /// <param name="path">
        /// Path for the directory.
        /// </param>
        /// <param name="parentId">
        /// ID of the parent directory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryResponse> CreateDirectoryAsync(
            string path,
            string? parentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}