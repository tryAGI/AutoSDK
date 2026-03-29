//HintName: G.IModelsClient.ExpandV1FluxPro10ExpandPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Expand an image by adding pixels on any side.<br/>
        /// Submits an image expansion task that adds the specified number of pixels to any combination of sides (top, bottom, left, right) while maintaining context.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> ExpandV1FluxPro10ExpandPostAsync(

            global::G.FluxProExpandInputs request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Expand an image by adding pixels on any side.<br/>
        /// Submits an image expansion task that adds the specified number of pixels to any combination of sides (top, bottom, left, right) while maintaining context.
        /// </summary>
        /// <param name="image">
        /// A Base64-encoded string representing the image you wish to expand.
        /// </param>
        /// <param name="top">
        /// Number of pixels to expand at the top of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="bottom">
        /// Number of pixels to expand at the bottom of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="left">
        /// Number of pixels to expand on the left side of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// Number of pixels to expand on the right side of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="prompt">
        /// The description of the changes you want to make. This text guides the expansion process, allowing you to specify features, styles, or modifications for the expanded areas.<br/>
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
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> ExpandV1FluxPro10ExpandPostAsync(
            string image,
            int? top = default,
            int? bottom = default,
            int? left = default,
            int? right = default,
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