//HintName: G.ITextToImageClient.CreateTextToImageTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// Create a Text to Image task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateTextToImageTaskAsync(

            global::G.TextToImageRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to Image task
        /// </summary>
        /// <param name="aiModel"></param>
        /// <param name="prompt">
        /// Text description for image generation
        /// </param>
        /// <param name="generateMultiView">
        /// Generate multi-angle views (cannot use with aspect_ratio)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateTextToImageTaskAsync(
            global::G.ImageAiModel aiModel,
            string prompt,
            bool? generateMultiView = default,
            global::G.TextToImageRequestPoseMode? poseMode = default,
            global::G.AspectRatio? aspectRatio = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}