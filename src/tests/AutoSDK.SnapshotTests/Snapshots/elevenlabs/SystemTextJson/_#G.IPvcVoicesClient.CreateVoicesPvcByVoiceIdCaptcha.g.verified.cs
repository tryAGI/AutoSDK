//HintName: G.IPvcVoicesClient.CreateVoicesPvcByVoiceIdCaptcha.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Verify Pvc Voice Captcha<br/>
        /// Submit captcha verification for PVC voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VerifyPVCVoiceCaptchaResponseModel> CreateVoicesPvcByVoiceIdCaptchaAsync(
            string voiceId,
            global::G.BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Verify Pvc Voice Captcha<br/>
        /// Submit captcha verification for PVC voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="recording">
        /// Audio recording of the user
        /// </param>
        /// <param name="recordingname">
        /// Audio recording of the user
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VerifyPVCVoiceCaptchaResponseModel> CreateVoicesPvcByVoiceIdCaptchaAsync(
            string voiceId,
            byte[] recording,
            string recordingname,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}