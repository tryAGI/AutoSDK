//HintName: G.IApi.CreateVideoFromImage.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Generate a video from an image.<br/>
        /// Start a new task to generate a video from an image prompt.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVideoFromImageResponse> CreateVideoFromImageAsync(
            global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::G.CreateVideoFromImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate a video from an image.<br/>
        /// Start a new task to generate a video from an image prompt.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="promptImage">
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </param>
        /// <param name="model">
        /// The model variant to use.
        /// </param>
        /// <param name="seed">
        /// Seed value for generating consistent results.
        /// </param>
        /// <param name="promptText">
        /// A detailed description of the output.
        /// </param>
        /// <param name="watermark">
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="ratio">
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVideoFromImageResponse> CreateVideoFromImageAsync(
            global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            string promptImage,
            global::G.CreateVideoFromImageRequestModel model = default,
            int? seed = default,
            string? promptText = default,
            bool? watermark = default,
            int? duration = default,
            global::G.CreateVideoFromImageRequestRatio? ratio = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}