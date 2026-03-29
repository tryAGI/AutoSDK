//HintName: G.Models.GladiaVocabularyItemDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GladiaVocabularyItemDTO
    {
        /// <summary>
        /// The vocabulary word or phrase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Alternative pronunciations for the vocabulary item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciations")]
        public global::System.Collections.Generic.IList<string>? Pronunciations { get; set; }

        /// <summary>
        /// Intensity for this specific vocabulary item (0.0 to 1.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public double? Intensity { get; set; }

        /// <summary>
        /// Language code for this vocabulary item (ISO 639-1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GladiaVocabularyItemDTO" /> class.
        /// </summary>
        /// <param name="value">
        /// The vocabulary word or phrase
        /// </param>
        /// <param name="pronunciations">
        /// Alternative pronunciations for the vocabulary item
        /// </param>
        /// <param name="intensity">
        /// Intensity for this specific vocabulary item (0.0 to 1.0)
        /// </param>
        /// <param name="language">
        /// Language code for this vocabulary item (ISO 639-1)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GladiaVocabularyItemDTO(
            string value,
            global::System.Collections.Generic.IList<string>? pronunciations,
            double? intensity,
            string? language)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Pronunciations = pronunciations;
            this.Intensity = intensity;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GladiaVocabularyItemDTO" /> class.
        /// </summary>
        public GladiaVocabularyItemDTO()
        {
        }
    }
}