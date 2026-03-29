//HintName: G.IModelsClient.FillV1FluxPro10FillPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX.1 Fill [pro] using an input image and mask.<br/>
        /// Submits an image generation task with the FLUX.1 Fill [pro] model using an input image and mask. Mask can be applied to alpha channel or submitted as a separate image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> FillV1FluxPro10FillPostAsync(

            global::G.FluxProFillInputs request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX.1 Fill [pro] using an input image and mask.<br/>
        /// Submits an image generation task with the FLUX.1 Fill [pro] model using an input image and mask. Mask can be applied to alpha channel or submitted as a separate image.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> FillV1FluxPro10FillPostAsync(
            string image,
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