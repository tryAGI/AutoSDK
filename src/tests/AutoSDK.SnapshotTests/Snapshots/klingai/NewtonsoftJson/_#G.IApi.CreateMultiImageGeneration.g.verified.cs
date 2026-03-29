//HintName: G.IApi.CreateMultiImageGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create multi-image generation task<br/>
        /// Generate images by combining multiple reference images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateMultiImageGenerationAsync(

            global::G.CreateMultiImageGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create multi-image generation task<br/>
        /// Generate images by combining multiple reference images.
        /// </summary>
        /// <param name="modelName">
        /// Model to use for generation.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for generation. Max 2500 characters.
        /// </param>
        /// <param name="images">
        /// Array of reference images as Base64 strings or URLs.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the output image.
        /// </param>
        /// <param name="n">
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateMultiImageGenerationAsync(
            string prompt,
            global::System.Collections.Generic.IList<string> images,
            string? modelName = default,
            global::G.CreateMultiImageGenerationRequestAspectRatio? aspectRatio = default,
            int? n = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}