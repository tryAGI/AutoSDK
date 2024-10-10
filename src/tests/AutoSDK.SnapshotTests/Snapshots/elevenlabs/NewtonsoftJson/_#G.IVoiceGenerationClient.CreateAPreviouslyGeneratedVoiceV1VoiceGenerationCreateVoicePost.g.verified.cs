//HintName: G.IVoiceGenerationClient.CreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceGenerationClient
    {
        /// <summary>
        /// Create A Previously Generated Voice<br/>
        /// Create a previously generated voice. This endpoint should be called after you fetched a generated_voice_id using /v1/voice-generation/generate-voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponseModel> CreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePostAsync(
            global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create A Previously Generated Voice<br/>
        /// Create a previously generated voice. This endpoint should be called after you fetched a generated_voice_id using /v1/voice-generation/generate-voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="voiceName">
        /// Name to use for the created voice.
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.
        /// </param>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.
        /// </param>
        /// <param name="playedNotSelectedVoiceIds">
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="labels">
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponseModel> CreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePostAsync(
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds = default,
            global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePostLabels? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}