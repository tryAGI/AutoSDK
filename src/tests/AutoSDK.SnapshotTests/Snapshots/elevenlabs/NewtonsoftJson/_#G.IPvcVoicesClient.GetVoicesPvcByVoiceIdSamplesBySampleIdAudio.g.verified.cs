//HintName: G.IPvcVoicesClient.GetVoicesPvcByVoiceIdSamplesBySampleIdAudio.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Retrieve Voice Sample Audio<br/>
        /// Retrieve the first 30 seconds of voice sample audio with or without noise removal.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceSamplePreviewResponseModel> GetVoicesPvcByVoiceIdSamplesBySampleIdAudioAsync(
            string voiceId,
            string sampleId,
            global::G.BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve Voice Sample Audio<br/>
        /// Retrieve the first 30 seconds of voice sample audio with or without noise removal.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceSamplePreviewResponseModel> GetVoicesPvcByVoiceIdSamplesBySampleIdAudioAsync(
            string voiceId,
            string sampleId,
            string? xiApiKey = default,
            bool? removeBackgroundNoise = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}