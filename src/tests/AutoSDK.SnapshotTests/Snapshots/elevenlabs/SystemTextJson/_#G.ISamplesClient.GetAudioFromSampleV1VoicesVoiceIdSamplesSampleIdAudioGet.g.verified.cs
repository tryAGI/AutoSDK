//HintName: G.ISamplesClient.GetAudioFromSampleV1VoicesVoiceIdSamplesSampleIdAudioGet.g.cs
#nullable enable

namespace G
{
    public partial interface ISamplesClient
    {
        /// <summary>
        /// Get Audio From Sample<br/>
        /// Returns the audio corresponding to a sample attached to a voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used, you can use GET https://api.elevenlabs.io/v1/voices/{voice_id} to list all the available samples for a voice.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HTTPValidationError> GetAudioFromSampleV1VoicesVoiceIdSamplesSampleIdAudioGetAsync(
            string voiceId,
            string sampleId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}