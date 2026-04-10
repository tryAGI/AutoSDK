//HintName: G.IMediaClient.MediaGetUploadUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMediaUploadUrlResponse> MediaGetUploadUrlAsync(

            global::G.GetMediaUploadUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a presigned upload URL for a media record
        /// </summary>
        /// <param name="traceId">
        /// The trace ID associated with the media record
        /// </param>
        /// <param name="observationId">
        /// The observation ID associated with the media record. If the media record is associated directly with a trace, this will be null.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the media record
        /// </param>
        /// <param name="contentLength">
        /// The size of the media record in bytes
        /// </param>
        /// <param name="sha256Hash">
        /// The SHA-256 hash of the media record
        /// </param>
        /// <param name="field">
        /// The trace / observation field the media record is associated with. This can be one of `input`, `output`, `metadata`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMediaUploadUrlResponse> MediaGetUploadUrlAsync(
            string traceId,
            global::G.MediaContentType contentType,
            long contentLength,
            string sha256Hash,
            string field,
            string? observationId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}