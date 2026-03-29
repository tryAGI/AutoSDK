//HintName: G.Models.LocalizeVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalizeVoiceRequest
    {
        /// <summary>
        /// The ID of the voice to localize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The name of the new localized voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the new localized voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Target language to localize the voice to.<br/>
        /// Options: English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LocalizeTargetLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LocalizeTargetLanguage Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_speaker_gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Gender OriginalSpeakerGender { get; set; }

        /// <summary>
        /// The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LocalizeDialectJsonConverter))]
        public global::G.LocalizeDialect? Dialect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizeVoiceRequest" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice to localize.
        /// </param>
        /// <param name="name">
        /// The name of the new localized voice.
        /// </param>
        /// <param name="description">
        /// The description of the new localized voice.
        /// </param>
        /// <param name="language">
        /// Target language to localize the voice to.<br/>
        /// Options: English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </param>
        /// <param name="originalSpeakerGender"></param>
        /// <param name="dialect">
        /// The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalizeVoiceRequest(
            string voiceId,
            string name,
            string description,
            global::G.LocalizeTargetLanguage language,
            global::G.Gender originalSpeakerGender,
            global::G.LocalizeDialect? dialect)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Language = language;
            this.OriginalSpeakerGender = originalSpeakerGender;
            this.Dialect = dialect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizeVoiceRequest" /> class.
        /// </summary>
        public LocalizeVoiceRequest()
        {
        }
    }
}