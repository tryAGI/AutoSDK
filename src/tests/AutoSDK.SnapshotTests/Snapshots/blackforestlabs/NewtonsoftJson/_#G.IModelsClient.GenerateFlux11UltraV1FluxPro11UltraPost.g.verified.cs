//HintName: G.IModelsClient.GenerateFlux11UltraV1FluxPro11UltraPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX 1.1 [pro] with ultra mode and optional raw mode.<br/>
        /// Submits an image generation task with FLUX 1.1 [pro] with ultra mode and optional raw mode.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux11UltraV1FluxPro11UltraPostAsync(

            global::G.FluxUltraInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX 1.1 [pro] with ultra mode and optional raw mode.<br/>
        /// Submits an image generation task with FLUX 1.1 [pro] with ultra mode and optional raw mode.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use for image generation.<br/>
        /// Example: A beautiful landscape with mountains and a lake
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility. If not provided, a random seed will be used.<br/>
        /// Example: 42
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the image between 21:9 and 9:21<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="raw">
        /// Generate less processed, more natural-looking images<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="imagePrompt">
        /// Optional image to remix in base64 format
        /// </param>
        /// <param name="imagePromptStrength">
        /// Blend between the prompt and the image prompt<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux11UltraV1FluxPro11UltraPostAsync(
            string? prompt = default,
            bool? promptUpsampling = default,
            int? seed = default,
            string? aspectRatio = default,
            int? safetyTolerance = default,
            global::G.OutputFormat? outputFormat = default,
            bool? raw = default,
            string? imagePrompt = default,
            double? imagePromptStrength = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}