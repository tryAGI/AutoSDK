//HintName: G.IVariationClient.CreateUniversalUpscalerJob.g.cs
#nullable enable

namespace G
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            global::G.CreateUniversalUpscalerJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="initImageId">
        /// The ID of the init image uploaded
        /// </param>
        /// <param name="generatedImageId">
        /// The ID of the generated image
        /// </param>
        /// <param name="variationId">
        /// The ID of the variation image
        /// </param>
        /// <param name="upscalerStyle">
        /// The style to upscale images using universal upscaler with.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="creativityStrength">
        /// The creativity strength of the universal upscaler, must be integer between 1 and 10<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="upscaleMultiplier">
        /// The upscale multiplier of the universal upscaler, must be number between 1.00 and 2.00<br/>
        /// Default Value: 1.5
        /// </param>
        /// <param name="prompt">
        /// The prompt for the universal upscaler
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            string? initImageId = default,
            string? generatedImageId = default,
            string? variationId = default,
            global::G.UniversalUpscalerStyle? upscalerStyle = global::G.UniversalUpscalerStyle.GENERAL,
            int? creativityStrength = 5,
            double? upscaleMultiplier = 1.5,
            string? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}