//HintName: G.IFileScanningClient.UploadFileChunk.g.cs
#nullable enable

namespace G
{
    public partial interface IFileScanningClient
    {
        /// <summary>
        /// Upload a file chunk<br/>
        /// Uploads a chunk of file data to the specified upload session.<br/>
        /// Use the X-Upload-Offset header to indicate the byte offset.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="xUploadOffset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UploadFileChunkAsync(
            global::System.Guid fileId,
            long xUploadOffset,

            byte[] request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}