//HintName: G.Models.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: en-US-JennyNeural
        /// </summary>
        /// <example>en-US-JennyNeural</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Voice customization options
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_config")]
        public global::G.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: en-US-JennyNeural
        /// </param>
        /// <param name="type"></param>
        /// <param name="voiceConfig">
        /// Voice customization options
        /// </param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </param>
        public AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft(
            string voiceId,
            global::G.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftType type,
            global::G.AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoftVoiceConfig? voiceConfig,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceConfig = voiceConfig;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft" /> class.
        /// </summary>
        public AgentCreateDtoPresenterPhotoAvatarVoiceMicrosoft()
        {
        }
    }
}