//HintName: G.IApi.CreateAvatar.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create avatar lip-sync task<br/>
        /// Generate a talking avatar video from an image and audio/text input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateAvatarAsync(

            global::G.CreateAvatarRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar lip-sync task<br/>
        /// Generate a talking avatar video from an image and audio/text input.
        /// </summary>
        /// <param name="image">
        /// Avatar image as Base64 string or URL.
        /// </param>
        /// <param name="audioId">
        /// Audio ID for lip-sync. Either audio_id or sound_file is required.
        /// </param>
        /// <param name="soundFile">
        /// Audio file as Base64 string or URL. Formats mp3, wav, m4a, aac. Max 5MB, 2-300 seconds.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for avatar generation. Max 2500 characters.
        /// </param>
        /// <param name="mode">
        /// Generation mode.<br/>
        /// Default Value: std
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateAvatarAsync(
            string image,
            string? audioId = default,
            string? soundFile = default,
            string? prompt = default,
            global::G.CreateAvatarRequestMode? mode = default,
            string? callbackUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}