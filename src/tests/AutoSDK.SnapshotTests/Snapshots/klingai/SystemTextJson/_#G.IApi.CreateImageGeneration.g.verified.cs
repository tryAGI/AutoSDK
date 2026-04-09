//HintName: G.IApi.CreateImageGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create image generation task<br/>
        /// Generate images from a text prompt with optional image reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageGenerationAsync(

            global::G.CreateImageGenerationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image generation task<br/>
        /// Generate images from a text prompt with optional image reference.
        /// </summary>
        /// <param name="modelName">
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </param>
        /// <param name="prompt">
        /// Text prompt for image generation. Max 2500 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </param>
        /// <param name="image">
        /// Reference image as Base64 string or URL.
        /// </param>
        /// <param name="imageReference">
        /// Type of image reference.
        /// </param>
        /// <param name="imageFidelity">
        /// Fidelity to the reference image. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="humanFidelity">
        /// Fidelity to human features. Range [0, 1]. Default 0.45.<br/>
        /// Default Value: 0.45
        /// </param>
        /// <param name="n">
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the output image.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Resolution of the output image.<br/>
        /// Default Value: 1k
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="externalTaskId">
        /// External task ID for tracking purposes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageGenerationAsync(
            string prompt,
            global::G.CreateImageGenerationRequestModelName? modelName = default,
            string? negativePrompt = default,
            string? image = default,
            global::G.CreateImageGenerationRequestImageReference? imageReference = default,
            double? imageFidelity = default,
            double? humanFidelity = default,
            int? n = default,
            global::G.CreateImageGenerationRequestAspectRatio? aspectRatio = default,
            global::G.CreateImageGenerationRequestResolution? resolution = default,
            string? callbackUrl = default,
            string? externalTaskId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}