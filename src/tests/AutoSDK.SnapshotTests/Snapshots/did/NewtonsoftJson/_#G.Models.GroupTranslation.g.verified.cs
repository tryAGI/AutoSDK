//HintName: G.Models.GroupTranslation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class GroupTranslation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GroupTranslationStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_at")]
        public string? GeneratedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proofreading")]
        public bool? Proofreading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale", Required = global::Newtonsoft.Json.Required.Always)]
        public string Locale { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_voice_id")]
        public string? CustomVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptions")]
        public global::System.Collections.Generic.IList<global::G.GroupTranslationTranscription>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupTranslation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="locale"></param>
        /// <param name="language"></param>
        /// <param name="generatedAt"></param>
        /// <param name="proofreading"></param>
        /// <param name="customVoiceId"></param>
        /// <param name="transcriptions"></param>
        public GroupTranslation(
            string id,
            global::G.GroupTranslationStatus status,
            string modifiedAt,
            string locale,
            string language,
            string? generatedAt,
            bool? proofreading,
            string? customVoiceId,
            global::System.Collections.Generic.IList<global::G.GroupTranslationTranscription>? transcriptions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.GeneratedAt = generatedAt;
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Proofreading = proofreading;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.CustomVoiceId = customVoiceId;
            this.Transcriptions = transcriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupTranslation" /> class.
        /// </summary>
        public GroupTranslation()
        {
        }
    }
}