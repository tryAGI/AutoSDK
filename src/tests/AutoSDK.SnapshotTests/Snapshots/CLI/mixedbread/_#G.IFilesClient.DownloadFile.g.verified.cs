//HintName: G.IFilesClient.DownloadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download a specific file by its ID.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to download.<br/>
        /// Returns:<br/>
        ///     FileStreamResponse: The response containing the file to be downloaded.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to download
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadFileAsync(
            global::System.Guid fileId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}