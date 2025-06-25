//HintName: G.IPvcVoicesClient.CreateVoicesPvcByVoiceIdVerification.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Request Manual Verification<br/>
        /// Request manual verification for a PVC voice.
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
        global::System.Threading.Tasks.Task<global::G.RequestPVCManualVerificationResponseModel> CreateVoicesPvcByVoiceIdVerificationAsync(
            string voiceId,
            global::G.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Request Manual Verification<br/>
        /// Request manual verification for a PVC voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="files">
        /// Verification documents
        /// </param>
        /// <param name="extraText">
        /// Extra text to be used in the manual verification process.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RequestPVCManualVerificationResponseModel> CreateVoicesPvcByVoiceIdVerificationAsync(
            string voiceId,
            global::System.Collections.Generic.IList<byte[]> files,
            string? xiApiKey = default,
            string? extraText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}