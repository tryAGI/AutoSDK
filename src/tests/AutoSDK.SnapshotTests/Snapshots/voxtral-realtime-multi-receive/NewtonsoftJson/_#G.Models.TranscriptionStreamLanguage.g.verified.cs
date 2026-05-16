//HintName: G.Models.TranscriptionStreamLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detected language event.
    /// </summary>
    public sealed partial class TranscriptionStreamLanguage
    {
        /// <summary>
        /// Must be 'transcription.language'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranscriptionStreamLanguageTypeJsonConverter))]
        public global::G.TranscriptionStreamLanguageType Type { get; set; }

        /// <summary>
        /// ISO 639-1 language code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamLanguage" /> class.
        /// </summary>
        /// <param name="language">
        /// ISO 639-1 language code.
        /// </param>
        /// <param name="type">
        /// Must be 'transcription.language'.
        /// </param>
        public TranscriptionStreamLanguage(
            string language,
            global::G.TranscriptionStreamLanguageType type)
        {
            this.Type = type;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamLanguage" /> class.
        /// </summary>
        public TranscriptionStreamLanguage()
        {
        }

    }
}