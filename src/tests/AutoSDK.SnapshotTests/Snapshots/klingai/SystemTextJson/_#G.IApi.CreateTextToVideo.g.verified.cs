//HintName: G.IApi.CreateTextToVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create text-to-video task<br/>
        /// Generate a video from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateTextToVideoAsync(

            global::G.CreateTextToVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create text-to-video task<br/>
        /// Generate a video from a text prompt.
        /// </summary>
        /// <param name="modelName">
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </param>
        /// <param name="prompt">
        /// Text prompt for video generation. Max 2500 characters.
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
        /// <param name="cameraControl"></param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="externalTaskId">
        /// External task ID for tracking purposes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateTextToVideoAsync(
            string prompt,
            global::G.CreateTextToVideoRequestModelName? modelName = default,
            string? negativePrompt = default,
            double? cfgScale = default,
            global::G.CreateTextToVideoRequestMode? mode = default,
            global::G.CreateTextToVideoRequestAspectRatio? aspectRatio = default,
            global::G.CreateTextToVideoRequestDuration? duration = default,
            global::G.CreateTextToVideoRequestSound? sound = default,
            global::G.CameraControl? cameraControl = default,
            string? callbackUrl = default,
            string? externalTaskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}