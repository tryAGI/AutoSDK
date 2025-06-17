//HintName: G.IPvcVoicesClient.CreateVoicesPvcByVoiceIdSamplesBySampleId.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Update Pvc Voice Sample<br/>
        /// Update a PVC voice sample - apply noise removal, or select speaker.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesPvcByVoiceIdSamplesBySampleIdAsync(
            string voiceId,
            string sampleId,
            global::G.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Pvc Voice Sample<br/>
        /// Update a PVC voice sample - apply noise removal, or select speaker.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="selectedSpeakerIds">
        /// Speaker IDs to be used for PVC training. Make sure you send all the speaker IDs you want to use for PVC training in one request because the last request will override the previous ones.<br/>
        /// Example: speaker_0
        /// </param>
        /// <param name="trimStartTime">
        /// The start time of the audio to be used for PVC training. Time should be in milliseconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="trimEndTime">
        /// The end time of the audio to be used for PVC training. Time should be in milliseconds<br/>
        /// Example: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesPvcByVoiceIdSamplesBySampleIdAsync(
            string voiceId,
            string sampleId,
            string? xiApiKey = default,
            bool? removeBackgroundNoise = default,
            global::System.Collections.Generic.IList<string>? selectedSpeakerIds = default,
            int? trimStartTime = default,
            int? trimEndTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}