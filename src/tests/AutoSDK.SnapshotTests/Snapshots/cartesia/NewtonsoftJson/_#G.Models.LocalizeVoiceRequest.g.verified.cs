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
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// The name of the new localized voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the new localized voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Target language to localize the voice to.<br/>
        /// Options: English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LocalizeTargetLanguage Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_speaker_gender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Gender OriginalSpeakerGender { get; set; } = default!;

        /// <summary>
        /// The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dialect")]
        public global::G.LocalizeDialect? Dialect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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