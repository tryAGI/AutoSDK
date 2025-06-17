//HintName: G.IPvcVoicesClient.CreateVoicesPvcByVoiceIdSamples.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Add Samples To Pvc Voice<br/>
        /// Add audio samples to a PVC voice
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SampleResponseModel>> CreateVoicesPvcByVoiceIdSamplesAsync(
            string voiceId,
            global::G.BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Samples To Pvc Voice<br/>
        /// Add audio samples to a PVC voice
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="files">
        /// Audio files used to create the voice.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SampleResponseModel>> CreateVoicesPvcByVoiceIdSamplesAsync(
            string voiceId,
            global::System.Collections.Generic.IList<byte[]> files,
            string? xiApiKey = default,
            bool? removeBackgroundNoise = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}