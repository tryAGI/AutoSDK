//HintName: G.Models.ElevenlabsTtsProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenlabsTtsProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ElevenlabsTtsProviderTypeJsonConverter))]
        public global::G.ElevenlabsTtsProviderType Type { get; set; }

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
        public global::G.ElevenlabsTtsProviderVoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// The model id from the list of available models. https://elevenlabs.io/docs/speech-synthesis/models.<br/>
        /// Default Value: eleven_multilingual_v2<br/>
        /// Example: eleven_multilingual_v2
        /// </summary>
        /// <example>eleven_multilingual_v2</example>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenlabsTtsProvider" /> class.
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
        /// Default Value: eleven_multilingual_v2<br/>
        /// Example: eleven_multilingual_v2
        /// </param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected voice<br/>
        /// Example: English (United States)
        /// </param>
        public ElevenlabsTtsProvider(
            global::G.ElevenlabsTtsProviderType type,
            string? voiceId,
            global::G.ElevenlabsTtsProviderVoiceConfig? voiceConfig,
            string? modelId,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.VoiceConfig = voiceConfig;
            this.ModelId = modelId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenlabsTtsProvider" /> class.
        /// </summary>
        public ElevenlabsTtsProvider()
        {
        }
    }
}