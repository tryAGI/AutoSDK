//HintName: G.IMediaClient.MediaPatch.g.cs
#nullable enable

namespace G
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Patch a media record
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task MediaPatchAsync(
            string mediaId,

            global::G.PatchMediaBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch a media record
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="uploadedAt">
        /// The date and time when the media record was uploaded
        /// </param>
        /// <param name="uploadHttpStatus">
        /// The HTTP status code of the upload
        /// </param>
        /// <param name="uploadHttpError">
        /// The HTTP error message of the upload
        /// </param>
        /// <param name="uploadTimeMs">
        /// The time in milliseconds it took to upload the media record
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task MediaPatchAsync(
            string mediaId,
            global::System.DateTime uploadedAt,
            int uploadHttpStatus,
            string? uploadHttpError = default,
            int? uploadTimeMs = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}