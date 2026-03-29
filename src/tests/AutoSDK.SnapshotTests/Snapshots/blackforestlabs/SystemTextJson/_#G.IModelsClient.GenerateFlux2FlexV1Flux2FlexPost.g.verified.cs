//HintName: G.IModelsClient.GenerateFlux2FlexV1Flux2FlexPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate or edit an image with FLUX.2 [FLEX]<br/>
        /// Submits an image generation or editing task with FLUX.2 [FLEX].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux2FlexV1Flux2FlexPostAsync(

            global::G.Flux2FlexInputs request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or edit an image with FLUX.2 [FLEX]<br/>
        /// Submits an image generation or editing task with FLUX.2 [FLEX].
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to use prompt upsampling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="inputImage">
        /// Path to the input image.
        /// </param>
        /// <param name="inputImage2">
        /// Path to the second input image.
        /// </param>
        /// <param name="inputImage3">
        /// Path to the third input image.
        /// </param>
        /// <param name="inputImage4">
        /// Path to the fourth input image.
        /// </param>
        /// <param name="inputImage5">
        /// Path to the fifth input image.
        /// </param>
        /// <param name="inputImage6">
        /// Path to the sixth input image.
        /// </param>
        /// <param name="inputImage7">
        /// Path to the seventh input image.
        /// </param>
        /// <param name="inputImage8">
        /// Path to the eighth input image.
        /// </param>
        /// <param name="inputImageBlobPath">
        /// Blob path to the input image.
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="width">
        /// Width of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="height">
        /// Height of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="guidance">
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 5F<br/>
        /// Example: 5F
        /// </param>
        /// <param name="steps">
        /// Number of steps for image generation. Higher steps lead to more detailed and realistic images.<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
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
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux2FlexV1Flux2FlexPostAsync(
            string prompt,
            bool? promptUpsampling = default,
            string? inputImage = default,
            string? inputImage2 = default,
            string? inputImage3 = default,
            string? inputImage4 = default,
            string? inputImage5 = default,
            string? inputImage6 = default,
            string? inputImage7 = default,
            string? inputImage8 = default,
            string? inputImageBlobPath = default,
            int? seed = default,
            int? width = default,
            int? height = default,
            double? guidance = default,
            int? steps = default,
            int? safetyTolerance = default,
            global::G.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}