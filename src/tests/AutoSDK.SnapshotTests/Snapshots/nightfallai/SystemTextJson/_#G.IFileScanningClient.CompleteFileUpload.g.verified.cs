//HintName: G.IFileScanningClient.CompleteFileUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IFileScanningClient
    {
        /// <summary>
        /// Complete a file upload<br/>
        /// Marks a file upload session as complete after all chunks have been uploaded.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CompleteFileUploadAsync(
            global::System.Guid fileId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}