//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderMicrosoft.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipStreamRequestScriptVariant1ProviderMicrosoft
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderMicrosoftTypeJsonConverter))]
        public global::G.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: en-US-JennyNeural
        /// </summary>
        /// <example>en-US-JennyNeural</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Voice customization options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_config")]
        public global::G.CreateClipStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// Voice customization options. To save the language of the selected agent voice<br/>
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
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestScriptVariant1ProviderMicrosoft" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipStreamRequestScriptVariant1ProviderMicrosoft(
            string voiceId,
            global::G.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType type,
            global::G.CreateClipStreamRequestScriptVariant1ProviderMicrosoftVoiceConfig? voiceConfig,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceConfig = voiceConfig;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestScriptVariant1ProviderMicrosoft" /> class.
        /// </summary>
        public CreateClipStreamRequestScriptVariant1ProviderMicrosoft()
        {
        }
    }
}