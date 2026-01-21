//HintName: G.IPvcVoicesClient.CreateVoicesPvcByVoiceIdTrain.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Run Pvc Training<br/>
        /// Start PVC training process for a voice.
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
        global::System.Threading.Tasks.Task<global::G.StartPVCVoiceTrainingResponseModel> CreateVoicesPvcByVoiceIdTrainAsync(
            string voiceId,
            global::G.BodyRunPVCTrainingV1VoicesPvcVoiceIdTrainPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run Pvc Training<br/>
        /// Start PVC training process for a voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="modelId">
        /// The model ID to use for the conversion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartPVCVoiceTrainingResponseModel> CreateVoicesPvcByVoiceIdTrainAsync(
            string voiceId,
            string? xiApiKey = default,
            string? modelId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}