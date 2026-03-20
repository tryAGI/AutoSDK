//HintName: G.IDubbingClient.Create2.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create A New Speaker
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeakerCreatedResponse> Create2Async(
            string dubbingId,

            global::G.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A New Speaker
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="speakerName">
        /// Name to attribute to this speaker.
        /// </param>
        /// <param name="voiceId">
        /// Either the identifier of a voice from the ElevenLabs voice library, or one of ['track-clone', 'clip-clone'].
        /// </param>
        /// <param name="voiceStability">
        /// For models that support it, the voice similarity value to use. This will default to 0.65, with a valid range of [0.0, 1.0].
        /// </param>
        /// <param name="voiceSimilarity">
        /// For models that support it, the voice similarity value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </param>
        /// <param name="voiceStyle">
        /// For models that support it, the voice style value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeakerCreatedResponse> Create2Async(
            string dubbingId,
            string? xiApiKey = default,
            string? speakerName = default,
            string? voiceId = default,
            double? voiceStability = default,
            double? voiceSimilarity = default,
            double? voiceStyle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}