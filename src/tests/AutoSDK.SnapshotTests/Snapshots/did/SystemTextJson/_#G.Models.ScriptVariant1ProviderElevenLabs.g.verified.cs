//HintName: G.Models.ScriptVariant1ProviderElevenLabs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScriptVariant1ProviderElevenLabs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScriptVariant1ProviderElevenLabsTypeJsonConverter))]
        public global::G.ScriptVariant1ProviderElevenLabsType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: 21m00Tcm4TlvDq8ikWAM<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </summary>
        /// <example>21m00Tcm4TlvDq8ikWAM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Voice customization options. Read more here: https://docs.elevenlabs.io/speech-synthesis/voice-settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_config")]
        public global::G.ScriptVariant1ProviderElevenLabsVoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// The model id from the list of available models. https://elevenlabs.io/docs/speech-synthesis/models.<br/>
        /// Default Value: eleven_multilingual_v2<br/>
        /// Example: eleven_multilingual_v2
        /// </summary>
        /// <example>eleven_multilingual_v2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice customization options. To save the language of the selected voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptVariant1ProviderElevenLabs" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScriptVariant1ProviderElevenLabs(
            global::G.ScriptVariant1ProviderElevenLabsType type,
            string? voiceId,
            global::G.ScriptVariant1ProviderElevenLabsVoiceConfig? voiceConfig,
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
        /// Initializes a new instance of the <see cref="ScriptVariant1ProviderElevenLabs" /> class.
        /// </summary>
        public ScriptVariant1ProviderElevenLabs()
        {
        }
    }
}