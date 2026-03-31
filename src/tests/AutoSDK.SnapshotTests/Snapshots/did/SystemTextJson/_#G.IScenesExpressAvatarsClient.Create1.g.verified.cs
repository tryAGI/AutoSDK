//HintName: G.IScenesExpressAvatarsClient.Create1.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Create an Express Avatar
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Create1Response> Create1Async(

            global::G.Create1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Express Avatar
        /// </summary>
        /// <param name="sourceUrl">
        /// The URL of the source video to create an avatar from<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="consentId">
        /// Unique identifier of a valid consent video
        /// </param>
        /// <param name="name">
        /// A name for the avatar
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </param>
        /// <param name="isGreenscreen">
        /// Whether the video is a green screen video
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Create1Response> Create1Async(
            string sourceUrl,
            string? consentId = default,
            string? name = default,
            string? webhook = default,
            string? userData = default,
            bool? isGreenscreen = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}