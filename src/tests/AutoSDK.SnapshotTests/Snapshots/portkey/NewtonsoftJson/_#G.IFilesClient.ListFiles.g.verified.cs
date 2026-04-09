//HintName: G.IFilesClient.ListFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFilesResponse> ListFilesAsync(
            string? purpose = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}