//HintName: G.Models.GladiaCustomVocabularyConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GladiaCustomVocabularyConfigDTO
    {
        /// <summary>
        /// Array of vocabulary items (strings or objects with value, pronunciations, intensity, language)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vocabulary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.GladiaVocabularyItemDTO>> Vocabulary { get; set; } = default!;

        /// <summary>
        /// Default intensity for vocabulary items (0.0 to 1.0)<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaultIntensity")]
        public double? DefaultIntensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GladiaCustomVocabularyConfigDTO" /> class.
        /// </summary>
        /// <param name="vocabulary">
        /// Array of vocabulary items (strings or objects with value, pronunciations, intensity, language)
        /// </param>
        /// <param name="defaultIntensity">
        /// Default intensity for vocabulary items (0.0 to 1.0)<br/>
        /// Default Value: 0.5F
        /// </param>
        public GladiaCustomVocabularyConfigDTO(
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.GladiaVocabularyItemDTO>> vocabulary,
            double? defaultIntensity)
        {
            this.Vocabulary = vocabulary ?? throw new global::System.ArgumentNullException(nameof(vocabulary));
            this.DefaultIntensity = defaultIntensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GladiaCustomVocabularyConfigDTO" /> class.
        /// </summary>
        public GladiaCustomVocabularyConfigDTO()
        {
        }
    }
}