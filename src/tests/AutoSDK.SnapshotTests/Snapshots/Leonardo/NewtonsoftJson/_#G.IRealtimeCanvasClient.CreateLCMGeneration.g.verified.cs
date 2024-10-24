//HintName: G.IRealtimeCanvasClient.CreateLCMGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IRealtimeCanvasClient
    {
        /// <summary>
        /// Create LCM Generation<br/>
        /// This endpoint will generate a LCM image generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLCMGenerationResponse> CreateLCMGenerationAsync(
            global::G.CreateLCMGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create LCM Generation<br/>
        /// This endpoint will generate a LCM image generation.
        /// </summary>
        /// <param name="imageDataUrl">
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </param>
        /// <param name="prompt">
        /// The prompt used to generate images
        /// </param>
        /// <param name="guidance">
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </param>
        /// <param name="strength">
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </param>
        /// <param name="requestTimestamp"></param>
        /// <param name="style">
        /// The style to generate LCM images with.
        /// </param>
        /// <param name="steps">
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </param>
        /// <param name="width">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="height">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="seed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLCMGenerationResponse> CreateLCMGenerationAsync(
            string imageDataUrl,
            string prompt,
            double? guidance = default,
            double? strength = default,
            string? requestTimestamp = default,
            global::G.LcmGenerationStyle? style = default,
            int? steps = default,
            int? width = default,
            int? height = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}