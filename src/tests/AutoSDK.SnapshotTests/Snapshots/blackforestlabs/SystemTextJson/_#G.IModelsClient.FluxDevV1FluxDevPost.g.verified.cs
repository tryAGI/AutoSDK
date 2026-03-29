//HintName: G.IModelsClient.FluxDevV1FluxDevPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX.1 [dev].<br/>
        /// Submits an image generation task with FLUX.1 [dev].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> FluxDevV1FluxDevPostAsync(

            global::G.FluxDevInputs request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX.1 [dev].<br/>
        /// Submits an image generation task with FLUX.1 [dev].
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="imagePrompt">
        /// Optional base64 encoded image to use as a prompt for generation.
        /// </param>
        /// <param name="width">
        /// Width of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Height of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="steps">
        /// Number of steps for the image generation process.<br/>
        /// Default Value: 28<br/>
        /// Example: 28
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="guidance">
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 3F<br/>
        /// Example: 3F
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
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> FluxDevV1FluxDevPostAsync(
            string? prompt = default,
            string? imagePrompt = default,
            int? width = default,
            int? height = default,
            int? steps = default,
            bool? promptUpsampling = default,
            int? seed = default,
            double? guidance = default,
            int? safetyTolerance = default,
            global::G.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}