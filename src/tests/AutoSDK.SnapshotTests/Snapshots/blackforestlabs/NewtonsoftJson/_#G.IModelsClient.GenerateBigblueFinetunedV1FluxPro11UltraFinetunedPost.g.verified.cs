//HintName: G.IModelsClient.GenerateBigblueFinetunedV1FluxPro11UltraFinetunedPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX 1.1 [pro] finetune with ultra mode.<br/>
        /// Submits an image generation task with FLUX 1.1 [pro] finetune with ultra mode.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostAsync(

            global::G.FinetuneFluxUltraInput request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX 1.1 [pro] finetune with ultra mode.<br/>
        /// Submits an image generation task with FLUX 1.1 [pro] finetune with ultra mode.
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to use.<br/>
        /// Example: my-finetune
        /// </param>
        /// <param name="finetuneStrength">
        /// Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for image generation.<br/>
        /// Example: A beautiful landscape with mountains and a lake
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
        /// <param name="imagePrompt">
        /// Optional image to remix in base64 format
        /// </param>
        /// <param name="imagePromptStrength">
        /// Blend between the prompt and the image prompt<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostAsync(
            string finetuneId,
            double? finetuneStrength = default,
            string? prompt = default,
            int? seed = default,
            string? aspectRatio = default,
            int? safetyTolerance = default,
            global::G.OutputFormat? outputFormat = default,
            string? imagePrompt = default,
            double? imagePromptStrength = default,
            bool? promptUpsampling = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}