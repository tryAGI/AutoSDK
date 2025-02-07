//HintName: G.Models.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost
    {
        /// <summary>
        /// Name to use for the created voice.<br/>
        /// Example: Little squeaky mouse
        /// </summary>
        /// <example>Little squeaky mouse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </summary>
        /// <example>A sassy little squeaky mouse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceDescription { get; set; }

        /// <summary>
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </summary>
        /// <example>37HceQefKmEi3bGovXjL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedVoiceId { get; set; }

        /// <summary>
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("played_not_selected_voice_ids")]
        public global::System.Collections.Generic.IList<string>? PlayedNotSelectedVoiceIds { get; set; }

        /// <summary>
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost" /> class.
        /// </summary>
        /// <param name="voiceName">
        /// Name to use for the created voice.<br/>
        /// Example: Little squeaky mouse
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </param>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </param>
        /// <param name="playedNotSelectedVoiceIds">
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="labels">
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost(
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.GeneratedVoiceId = generatedVoiceId ?? throw new global::System.ArgumentNullException(nameof(generatedVoiceId));
            this.PlayedNotSelectedVoiceIds = playedNotSelectedVoiceIds;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost" /> class.
        /// </summary>
        public BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost()
        {
        }
    }
}