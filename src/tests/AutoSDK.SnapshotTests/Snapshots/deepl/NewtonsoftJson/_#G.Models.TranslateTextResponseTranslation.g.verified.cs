//HintName: G.Models.TranslateTextResponseTranslation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateTextResponseTranslation
    {
        /// <summary>
        /// The language detected in the source text. It reflects the value of the `source_lang` parameter, when specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detected_source_language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SourceLanguageJsonConverter))]
        public global::G.SourceLanguage? DetectedSourceLanguage { get; set; }

        /// <summary>
        /// The translated text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Number of characters counted by DeepL for billing purposes. Only present if the show_billed_characters parameter is set to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billed_characters")]
        public int? BilledCharacters { get; set; }

        /// <summary>
        /// Indicates the translation model used. Only present if model_type parameter is included in the request.<br/>
        /// Example: quality_optimized
        /// </summary>
        /// <example>quality_optimized</example>
        [global::Newtonsoft.Json.JsonProperty("model_type_used")]
        public string? ModelTypeUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextResponseTranslation" /> class.
        /// </summary>
        /// <param name="detectedSourceLanguage">
        /// The language detected in the source text. It reflects the value of the `source_lang` parameter, when specified.
        /// </param>
        /// <param name="text">
        /// The translated text.
        /// </param>
        /// <param name="billedCharacters">
        /// Number of characters counted by DeepL for billing purposes. Only present if the show_billed_characters parameter is set to true.
        /// </param>
        /// <param name="modelTypeUsed">
        /// Indicates the translation model used. Only present if model_type parameter is included in the request.<br/>
        /// Example: quality_optimized
        /// </param>
        public TranslateTextResponseTranslation(
            global::G.SourceLanguage? detectedSourceLanguage,
            string? text,
            int? billedCharacters,
            string? modelTypeUsed)
        {
            this.DetectedSourceLanguage = detectedSourceLanguage;
            this.Text = text;
            this.BilledCharacters = billedCharacters;
            this.ModelTypeUsed = modelTypeUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextResponseTranslation" /> class.
        /// </summary>
        public TranslateTextResponseTranslation()
        {
        }
    }
}