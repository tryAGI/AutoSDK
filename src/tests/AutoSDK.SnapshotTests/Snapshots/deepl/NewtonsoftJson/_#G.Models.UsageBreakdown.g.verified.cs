//HintName: G.Models.UsageBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of character usage by category.
    /// </summary>
    public sealed partial class UsageBreakdown
    {
        /// <summary>
        /// Total number of characters used.<br/>
        /// Example: 9619
        /// </summary>
        /// <example>9619</example>
        [global::Newtonsoft.Json.JsonProperty("total_characters")]
        public int? TotalCharacters { get; set; }

        /// <summary>
        /// Number of characters used for text translation.<br/>
        /// Example: 4892
        /// </summary>
        /// <example>4892</example>
        [global::Newtonsoft.Json.JsonProperty("text_translation_characters")]
        public int? TextTranslationCharacters { get; set; }

        /// <summary>
        /// Number of characters used for document translation.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("document_translation_characters")]
        public int? DocumentTranslationCharacters { get; set; }

        /// <summary>
        /// Number of characters used for text improvement.<br/>
        /// Example: 4727
        /// </summary>
        /// <example>4727</example>
        [global::Newtonsoft.Json.JsonProperty("text_improvement_characters")]
        public int? TextImprovementCharacters { get; set; }

        /// <summary>
        /// Duration of speech-to-text usage in milliseconds.<br/>
        /// Example: 1800000
        /// </summary>
        /// <example>1800000</example>
        [global::Newtonsoft.Json.JsonProperty("speech_to_text_milliseconds")]
        public int? SpeechToTextMilliseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdown" /> class.
        /// </summary>
        /// <param name="totalCharacters">
        /// Total number of characters used.<br/>
        /// Example: 9619
        /// </param>
        /// <param name="textTranslationCharacters">
        /// Number of characters used for text translation.<br/>
        /// Example: 4892
        /// </param>
        /// <param name="documentTranslationCharacters">
        /// Number of characters used for document translation.<br/>
        /// Example: 0
        /// </param>
        /// <param name="textImprovementCharacters">
        /// Number of characters used for text improvement.<br/>
        /// Example: 4727
        /// </param>
        /// <param name="speechToTextMilliseconds">
        /// Duration of speech-to-text usage in milliseconds.<br/>
        /// Example: 1800000
        /// </param>
        public UsageBreakdown(
            int? totalCharacters,
            int? textTranslationCharacters,
            int? documentTranslationCharacters,
            int? textImprovementCharacters,
            int? speechToTextMilliseconds)
        {
            this.TotalCharacters = totalCharacters;
            this.TextTranslationCharacters = textTranslationCharacters;
            this.DocumentTranslationCharacters = documentTranslationCharacters;
            this.TextImprovementCharacters = textImprovementCharacters;
            this.SpeechToTextMilliseconds = speechToTextMilliseconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdown" /> class.
        /// </summary>
        public UsageBreakdown()
        {
        }
    }
}