//HintName: G.IMotionClient.CreateSVDMotionGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IMotionClient
    {
        /// <summary>
        /// Create SVD Motion Generation<br/>
        /// This endpoint will generate a SVD motion generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSVDMotionGenerationResponse> CreateSVDMotionGenerationAsync(
            global::G.CreateSVDMotionGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create SVD Motion Generation<br/>
        /// This endpoint will generate a SVD motion generation.
        /// </summary>
        /// <param name="imageId">
        /// The ID of the image, supports generated images, variation images, and init images.
        /// </param>
        /// <param name="isPublic">
        /// Whether the generation is public or not
        /// </param>
        /// <param name="isInitImage">
        /// If it is an init image uploaded by the user. This image is uploaded from endpoint: Upload init image.
        /// </param>
        /// <param name="isVariation">
        /// If it is a variation image.
        /// </param>
        /// <param name="motionStrength">
        /// The motion strength.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSVDMotionGenerationResponse> CreateSVDMotionGenerationAsync(
            string imageId,
            bool? isPublic = default,
            bool? isInitImage = default,
            bool? isVariation = default,
            int? motionStrength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}