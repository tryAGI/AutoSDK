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
        /// Name to use for the created voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// Description to use for the created voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceDescription { get; set; } = default!;

        /// <summary>
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedVoiceId { get; set; } = default!;

        /// <summary>
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("played_not_selected_voice_ids")]
        public global::System.Collections.Generic.IList<string>? PlayedNotSelectedVoiceIds { get; set; }

        /// <summary>
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePostLabels? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}