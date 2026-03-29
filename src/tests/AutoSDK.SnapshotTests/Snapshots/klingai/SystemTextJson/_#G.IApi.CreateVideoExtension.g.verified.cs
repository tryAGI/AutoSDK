//HintName: G.IApi.CreateVideoExtension.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create video extension task<br/>
        /// Extend the duration of an existing video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateVideoExtensionAsync(

            global::G.CreateVideoExtensionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create video extension task<br/>
        /// Extend the duration of an existing video.
        /// </summary>
        /// <param name="videoId">
        /// ID of the video to extend.
        /// </param>
        /// <param name="prompt">
        /// Optional text prompt to guide the extension. Max 2500 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </param>
        /// <param name="cfgScale">
        /// Classifier-free guidance scale. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateVideoExtensionAsync(
            string videoId,
            string? prompt = default,
            string? negativePrompt = default,
            double? cfgScale = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}