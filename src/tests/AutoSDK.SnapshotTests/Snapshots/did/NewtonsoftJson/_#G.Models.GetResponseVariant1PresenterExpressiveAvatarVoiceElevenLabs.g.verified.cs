//HintName: G.Models.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsTypeJsonConverter))]
        public global::G.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: 21m00Tcm4TlvDq8ikWAM<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </summary>
        /// <example>21m00Tcm4TlvDq8ikWAM</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Voice customization options. Read more here: https://docs.elevenlabs.io/speech-synthesis/voice-settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_config")]
        public global::G.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// The model id from the list of available models. https://elevenlabs.io/docs/speech-synthesis/models.<br/>
        /// Example: eleven_flash_v2_5
        /// </summary>
        /// <example>eleven_flash_v2_5</example>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice customization options. To save the language of the selected voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The access level of the requested voice.<br/>
        /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccessJsonConverter))]
        public global::G.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: 21m00Tcm4TlvDq8ikWAM<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="voiceConfig">
        /// Voice customization options. Read more here: https://docs.elevenlabs.io/speech-synthesis/voice-settings
        /// </param>
        /// <param name="modelId">
        /// The model id from the list of available models. https://elevenlabs.io/docs/speech-synthesis/models.<br/>
        /// Example: eleven_flash_v2_5
        /// </param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected voice<br/>
        /// Example: English (United States)
        /// </param>
        /// <param name="access">
        /// The access level of the requested voice.<br/>
        /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
        /// </param>
        public GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs(
            global::G.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsType type,
            string? voiceId,
            global::G.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsVoiceConfig? voiceConfig,
            string? modelId,
            string? language,
            global::G.GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabsAccess? access)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.VoiceConfig = voiceConfig;
            this.ModelId = modelId;
            this.Language = language;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs" /> class.
        /// </summary>
        public GetResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs()
        {
        }
    }
}