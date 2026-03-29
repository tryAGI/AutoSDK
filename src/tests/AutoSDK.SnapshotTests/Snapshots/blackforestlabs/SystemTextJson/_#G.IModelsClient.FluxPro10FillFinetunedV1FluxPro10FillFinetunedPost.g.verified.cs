//HintName: G.IModelsClient.FluxPro10FillFinetunedV1FluxPro10FillFinetunedPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX.1 Fill [pro] finetune using an input image and mask.<br/>
        /// Submits an image generation task with the FLUX.1 Fill [pro] finetune model using an input image and mask. Mask can be applied to alpha channel or submitted as a separate image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> FluxPro10FillFinetunedV1FluxPro10FillFinetunedPostAsync(

            global::G.FinetuneFluxProFillInputs request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX.1 Fill [pro] finetune using an input image and mask.<br/>
        /// Submits an image generation task with the FLUX.1 Fill [pro] finetune model using an input image and mask. Mask can be applied to alpha channel or submitted as a separate image.
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to use.<br/>
        /// Example: my-finetune
        /// </param>
        /// <param name="finetuneStrength">
        /// Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0<br/>
        /// Default Value: 1.1F
        /// </param>
        /// <param name="image">
        /// A Base64-encoded string representing the image you wish to modify. Can contain alpha mask if desired.
        /// </param>
        /// <param name="mask">
        /// A Base64-encoded string representing a mask for the areas you want to modify in the image. The mask should be the same dimensions as the image and in black and white. Black areas (0%) indicate no modification, while white areas (100%) specify areas for inpainting. Optional if you provide an alpha mask in the original image. Validation: The endpoint verifies that the dimensions of the mask match the original image.
        /// </param>
        /// <param name="prompt">
        /// The description of the changes you want to make. This text guides the inpainting process, allowing you to specify features, styles, or modifications for the masked area.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="steps">
        /// Number of steps for the image generation process<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility
        /// </param>
        /// <param name="guidance">
        /// Guidance strength for the image generation process<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> FluxPro10FillFinetunedV1FluxPro10FillFinetunedPostAsync(
            string finetuneId,
            string image,
            double? finetuneStrength = default,
            string? mask = default,
            string? prompt = default,
            int? steps = default,
            bool? promptUpsampling = default,
            int? seed = default,
            double? guidance = default,
            global::G.OutputFormat? outputFormat = default,
            int? safetyTolerance = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}