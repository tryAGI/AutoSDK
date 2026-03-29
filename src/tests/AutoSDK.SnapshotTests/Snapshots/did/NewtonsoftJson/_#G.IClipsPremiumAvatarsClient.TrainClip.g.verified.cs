//HintName: G.IClipsPremiumAvatarsClient.TrainClip.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Create a Premium+ Avatar
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainClipResponse> TrainClipAsync(

            global::G.TrainClipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Premium+ Avatar
        /// </summary>
        /// <param name="sourceUrl">
        /// The source URL of the clip video to train, the video must be longer than 3 minutes and have a resolution higher than 0.5 megapixels.
        /// </param>
        /// <param name="name">
        /// A name for the avatar
        /// </param>
        /// <param name="gender">
        /// The gender of the presenter
        /// </param>
        /// <param name="consentId">
        /// Id of the related consent for the clip
        /// </param>
        /// <param name="webhook">
        /// The webhook to call when the training is done
        /// </param>
        /// <param name="config">
        /// Configuration options for the clip training
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainClipResponse> TrainClipAsync(
            string sourceUrl,
            global::G.TrainClipRequestGender gender,
            string? name = default,
            string? consentId = default,
            string? webhook = default,
            global::G.TrainClipRequestConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}