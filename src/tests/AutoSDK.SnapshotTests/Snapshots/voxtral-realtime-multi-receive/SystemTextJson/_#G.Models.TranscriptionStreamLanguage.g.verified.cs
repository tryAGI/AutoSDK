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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionStreamLanguageTypeJsonConverter))]
        public global::G.TranscriptionStreamLanguageType Type { get; set; }

        /// <summary>
        /// ISO 639-1 language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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