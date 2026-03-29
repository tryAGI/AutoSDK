//HintName: G.Models.CustomVocabularyConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomVocabularyConfigDTO
    {
        /// <summary>
        /// Specific vocabulary list to feed the transcription model with. Each item can be a string or an object with the following properties: value, intensity, pronunciations, language.<br/>
        /// Example: [Westeros, {"value":"Stark"}, {"value":"Night\u0027s Watch","pronunciations":["Nightz Watch"],"intensity":0.4,"language":"en"}]
        /// </summary>
        /// <example>[Westeros, {"value":"Stark"}, {"value":"Night\u0027s Watch","pronunciations":["Nightz Watch"],"intensity":0.4,"language":"en"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocabulary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.CustomVocabularyEntryDTO, string>> Vocabulary { get; set; }

        /// <summary>
        /// Default intensity for the custom vocabulary<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_intensity")]
        public double? DefaultIntensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabularyConfigDTO" /> class.
        /// </summary>
        /// <param name="vocabulary">
        /// Specific vocabulary list to feed the transcription model with. Each item can be a string or an object with the following properties: value, intensity, pronunciations, language.<br/>
        /// Example: [Westeros, {"value":"Stark"}, {"value":"Night\u0027s Watch","pronunciations":["Nightz Watch"],"intensity":0.4,"language":"en"}]
        /// </param>
        /// <param name="defaultIntensity">
        /// Default intensity for the custom vocabulary<br/>
        /// Example: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomVocabularyConfigDTO(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CustomVocabularyEntryDTO, string>> vocabulary,
            double? defaultIntensity)
        {
            this.Vocabulary = vocabulary ?? throw new global::System.ArgumentNullException(nameof(vocabulary));
            this.DefaultIntensity = defaultIntensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabularyConfigDTO" /> class.
        /// </summary>
        public CustomVocabularyConfigDTO()
        {
        }
    }
}