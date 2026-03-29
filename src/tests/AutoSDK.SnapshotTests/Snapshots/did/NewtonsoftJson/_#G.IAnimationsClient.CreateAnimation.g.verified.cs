//HintName: G.IAnimationsClient.CreateAnimation.g.cs
#nullable enable

namespace G
{
    public partial interface IAnimationsClient
    {
        /// <summary>
        /// Create an animation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateAnimationResponse> CreateAnimationAsync(

            global::G.CreateAnimationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an animation
        /// </summary>
        /// <param name="sourceUrl">
        /// The URL of the source image to be animated by the driver video. Image type of jpg|jpeg|tiff|png|bmp<br/>
        /// Default Value: https://d-id-public-bucket.s3.us-west-2.amazonaws.com/alice.jpg<br/>
        /// Example: https://path.to.directory/image.jpg
        /// </param>
        /// <param name="driverUrl">
        /// The URL of the driver video to drive the animation, if not provided a driver video will be selected for you from the predefined DriversBank<br/>
        /// Example: bank://nostalgia/
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the animation video, if not provided use default destination<br/>
        /// Supports S3 Signed URLs<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="face">
        /// the face to animate - otherwise detects the dominant face<br/>
        /// Example: {"top_left":[0,0],"size":512}
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="config">
        /// Advanced configuration option
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the animation response and webhook.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateAnimationResponse> CreateAnimationAsync(
            string? sourceUrl = default,
            string? driverUrl = default,
            string? resultUrl = default,
            global::G.CreateAnimationRequestFace? face = default,
            string? webhook = default,
            global::G.CreateAnimationRequestConfig? config = default,
            string? userData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}