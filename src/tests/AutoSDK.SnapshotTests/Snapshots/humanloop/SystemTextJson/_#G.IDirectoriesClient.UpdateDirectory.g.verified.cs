//HintName: G.IDirectoriesClient.UpdateDirectory.g.cs
#nullable enable

namespace G
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Update Directory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryResponse> UpdateDirectoryAsync(
            string id,

            global::G.UpdateDirectoryRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Directory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path"></param>
        /// <param name="parentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryResponse> UpdateDirectoryAsync(
            string id,
            string? path = default,
            string? parentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}