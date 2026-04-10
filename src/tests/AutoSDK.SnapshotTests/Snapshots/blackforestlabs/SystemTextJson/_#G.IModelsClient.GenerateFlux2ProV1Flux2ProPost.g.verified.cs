//HintName: G.IModelsClient.GenerateFlux2ProV1Flux2ProPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate or edit an image with FLUX.2 [PRO]<br/>
        /// Submits an image generation or edit task with FLUX.2 [PRO].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux2ProV1Flux2ProPostAsync(

            global::G.Flux2Inputs request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or edit an image with FLUX.2 [PRO]<br/>
        /// Submits an image generation or edit task with FLUX.2 [PRO].
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="disablePup">
        /// Disable prompt upsampling for this request.<br/>
        /// Default Value: false
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
        /// <param name="transparentBg">
        /// Remove the background from the generated image, returning a transparent RGBA PNG.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse>> GenerateFlux2ProV1Flux2ProPostAsync(
            string prompt,
            bool? disablePup = default,
            string? inputImage = default,
            string? inputImage2 = default,
            string? inputImage3 = default,
            string? inputImage4 = default,
            string? inputImage5 = default,
            string? inputImage6 = default,
            string? inputImage7 = default,
            string? inputImage8 = default,
            int? seed = default,
            int? width = default,
            int? height = default,
            int? safetyTolerance = default,
            global::G.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            bool? transparentBg = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}