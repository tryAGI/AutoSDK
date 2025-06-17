//HintName: G.IPvcVoicesClient.GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudio.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Retrieve Separated Speaker Audio<br/>
        /// Retrieve the separated audio for a specific speaker.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="speakerId">
        /// Speaker ID to be used, you can use GET https://api.elevenlabs.io/v1/voices/{voice_id}/samples/{sample_id}/speakers to list all the available speakers for a sample.<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeakerAudioResponseModel> GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudioAsync(
            string voiceId,
            string sampleId,
            string speakerId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}