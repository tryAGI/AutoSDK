//HintName: G.Models.CustomVocabularyEntryDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomVocabularyEntryDTO
    {
        /// <summary>
        /// The text used to replace in the transcription.<br/>
        /// Example: Gladia
        /// </summary>
        /// <example>Gladia</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The global intensity of the feature.<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public double? Intensity { get; set; }

        /// <summary>
        /// The pronunciations used in the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciations")]
        public global::System.Collections.Generic.IList<string>? Pronunciations { get; set; }

        /// <summary>
        /// Specify the language in which it will be pronounced when sound comparison occurs. Default to transcription language.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter))]
        public global::G.TranscriptionLanguageCodeEnum? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabularyEntryDTO" /> class.
        /// </summary>
        /// <param name="value">
        /// The text used to replace in the transcription.<br/>
        /// Example: Gladia
        /// </param>
        /// <param name="intensity">
        /// The global intensity of the feature.<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="pronunciations">
        /// The pronunciations used in the transcription.
        /// </param>
        /// <param name="language">
        /// Specify the language in which it will be pronounced when sound comparison occurs. Default to transcription language.<br/>
        /// Example: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomVocabularyEntryDTO(
            string value,
            double? intensity,
            global::System.Collections.Generic.IList<string>? pronunciations,
            global::G.TranscriptionLanguageCodeEnum? language)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Intensity = intensity;
            this.Pronunciations = pronunciations;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabularyEntryDTO" /> class.
        /// </summary>
        public CustomVocabularyEntryDTO()
        {
        }
    }
}