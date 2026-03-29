//HintName: G.IApi.CreateImageToVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create image-to-video task<br/>
        /// Generate a video from an image input with optional prompt guidance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageToVideoAsync(

            global::G.CreateImageToVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image-to-video task<br/>
        /// Generate a video from an image input with optional prompt guidance.
        /// </summary>
        /// <param name="modelName">
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </param>
        /// <param name="image">
        /// Input image as Base64 string or URL. Formats supported are jpg, jpeg, png. Max size 10MB.
        /// </param>
        /// <param name="imageTail">
        /// End frame image as Base64 string or URL.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for video generation guidance. Max 2500 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </param>
        /// <param name="cfgScale">
        /// Classifier-free guidance scale. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="mode">
        /// Generation mode.<br/>
        /// Default Value: std
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the output video.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="sound">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: off
        /// </param>
        /// <param name="staticMask">
        /// Static mask image as Base64 string or URL.
        /// </param>
        /// <param name="dynamicMasks">
        /// Array of dynamic mask groups. Max 6 groups.
        /// </param>
        /// <param name="voiceList">
        /// Array of voice items for audio. Max 2 voices.
        /// </param>
        /// <param name="cameraControl"></param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="externalTaskId">
        /// External task ID for tracking purposes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageToVideoAsync(
            global::G.CreateImageToVideoRequestModelName? modelName = default,
            string? image = default,
            string? imageTail = default,
            string? prompt = default,
            string? negativePrompt = default,
            double? cfgScale = default,
            global::G.CreateImageToVideoRequestMode? mode = default,
            global::G.CreateImageToVideoRequestAspectRatio? aspectRatio = default,
            global::G.CreateImageToVideoRequestDuration? duration = default,
            global::G.CreateImageToVideoRequestSound? sound = default,
            string? staticMask = default,
            global::System.Collections.Generic.IList<global::G.DynamicMask>? dynamicMasks = default,
            global::System.Collections.Generic.IList<global::G.VoiceItem>? voiceList = default,
            global::G.CameraControl? cameraControl = default,
            string? callbackUrl = default,
            string? externalTaskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}