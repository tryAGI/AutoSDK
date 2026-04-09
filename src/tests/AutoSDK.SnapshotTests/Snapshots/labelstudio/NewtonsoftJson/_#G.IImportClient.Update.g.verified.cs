//HintName: G.IImportClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Update file upload<br/>
        /// Update a specific uploaded file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileUpload> UpdateAsync(
            int id,

            global::G.PatchedFileUploadRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update file upload<br/>
        /// Update a specific uploaded file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileUpload> UpdateAsync(
            int id,
            byte[]? file = default,
            string? filename = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}